using Models;
using Provider.EntityFramework;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Setting : Form
    {
        //On déclare les variables
        private readonly Context context;
        private readonly ContactService contactService;
        private readonly MailService mailService;
        public Models.Campagne currentCampagne;
        public string to;
        public string obj;
        public string msg;
        public bool allCampagne;
        public Setting(Models.Campagne currentCampagne, string to, string obj, string msg, bool allCampagne)
        {
            //On récupère les valeurs transmises en paramètre
            this.currentCampagne = currentCampagne;
            this.to = to;
            this.obj = obj;
            this.msg = msg;
            this.allCampagne = allCampagne;
            //Définition du context
            this.context = new Context();
            //On initialise les services
            this.contactService = new ContactService(this.context);
            this.mailService = new MailService(this.context);
            //On initialise les composants à afficher
            InitializeComponent();
        }

        /// <summary>
        /// Méthode appelé lorsqu'on clique sur le bouton envoyer
        /// </summary>
        public async void SendMail_Click(object sender, EventArgs e)
        {
            //On vérifies les champs saisie
            if(!String.IsNullOrEmpty(this.serverInput.Text)
                && !String.IsNullOrEmpty(this.emailFromInput.Text)
                && !String.IsNullOrEmpty(this.passwordInput.Text))
            {
                //On vérifie si il faut envoyer à toute la campagne ou seulement à une adresse
                if (this.allCampagne)
                {
                    //On récupère la liste des contacts de la campagne 
                    var contacts = await this.contactService.ContactListByCampagne(this.currentCampagne.Id);
                    //Pour chaque contact on envoie l'email
                    contacts.ForEach(c =>
                    {
                        //Méthode permettant d'envoyer un email à un contact
                        this.mailService.SendMail(this.serverInput.Text, this.emailFromInput.Text, c.Email, this.obj, this.msg, this.emailFromInput.Text, this.passwordInput.Text);
                    });
                }
                //Sinon on envoie l'email au contact saisie
                else
                {
                    //Méthode permettant d'envoyer un email à un contact
                    this.mailService.SendMail(this.serverInput.Text, this.emailFromInput.Text, this.to, this.obj, this.msg, this.emailFromInput.Text, this.passwordInput.Text);
                }

                //On ferme la fenêtre courrante
                this.Hide();
                //On retourne à la liste des campagnes
                var nextForm = new Campagne();
                nextForm.Show();
            }
        }

    }
}
