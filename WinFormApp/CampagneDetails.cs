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
    public partial class CampagneDetails : Form
    {
        private readonly Context context;
        private readonly ContactService contactService;

        public Models.Campagne currentCampagne;

        public CampagneDetails(Models.Campagne campagneSelected)
        {
            //On initialise le context
            this.context = new Context();
            //On initialise le service
            this.contactService = new ContactService(this.context);
            //Chargement des composants à afficher
            InitializeComponent();
            //On récupère la campagne qui a été passé en paramètre
            this.currentCampagne = campagneSelected;
            //On récupère le nom de campagne afin de l'afficher
            this.campagneName.Text = this.currentCampagne.Name;
            //Chargement des emails de la campagne
            this.LoadEmails();
        }

        /// <summary>
        /// Méthode permettant de charger les emails de la campagne
        /// </summary>
        public async void LoadEmails()
        {
            //On vide la liste des emails de la listBox "listEmailBox"
            this.listEmailBox.Items.Clear();
            //On réupère les contacts de la campagne en passant l'id de la campagne en paramètre
            var contacts = await this.contactService.ContactListByCampagne(this.currentCampagne.Id);
            //On boucle sur la liste des contacts précédemment récupéré
            contacts.ForEach(c =>
            {
                //On ajoute l'adresse mail du contact à la liste
                this.listEmailBox.Items.Add(c.Email);
            });
        }
    }
}
