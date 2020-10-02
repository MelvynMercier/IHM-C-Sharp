using Models;
using Provider.EntityFramework;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
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

        /// <summary>
        /// Evenement produit lors d'un click sur le bouton import
        /// </summary>
        public void OpenDialog_Click(object sender, EventArgs e)
        {
            //On déclare notre open dialog pour selectionner le fichier
            var fileDialog = new OpenFileDialog();
            //On ouvre ce dialog
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Si l'ouverture est reussi alors on copie la data du fichier dans une variable
                    var sr = new StreamReader(fileDialog.FileName);
                    //On utilise une méthode permettant de récupérer la data d'un fichier
                    ReadFile(sr.ReadToEnd());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        /// <summary>
        /// Méthode appeler permettant de lire un fichier
        /// </summary>
        public async void ReadFile(string text)
        {
            //On copie la data dans une variable
            var data = text;
            //On la découpe avec split("\r\n")
            var emailList = data.Split("\r\n");
            //On fait un appel à la méthode permettant d'ajouter une liste d'email
            await this.contactService.AddEmails(this.currentCampagne, emailList.ToList());
            //On rafraichit la liste des emails
            this.LoadEmails();
        }

        /// <summary>
        /// Evenement produit lors d'un click sur le bouton ajouter
        /// </summary>
        public async void AddEmail_Click(object sender, EventArgs e)
        {
            //Déclaration d"un nouvel objet Contact, vide
            var newContact = new Models.Contact();
            //L'emaiol saisie est ajouté au contact précédemment crée
            newContact.Email = this.inputEmail.Text;
            newContact.CampagneId = this.currentCampagne.Id;
            //Appel au service permettant de créer un contact
            await this.contactService.AddEmail(newContact);
            //Le champs de saisie est remit à null
            this.inputEmail.Text = null;
            //On charge de nouveau les emails
            this.LoadEmails();
        }

        /// <summary>
        /// Evenement produit lors d'un click sur une ligne de la liste des emails
        /// </summary>
        public void MoreInformations_Click(object sender, EventArgs e)
        {
            //On copie l'email de la liste dans une texteBox
            this.contactInfoInput.Text = this.listEmailBox.SelectedItem.ToString();
        }

        /// <summary>
        /// Evenement produit lors d'un click sur le bouton des modifier
        /// </summary>
        public async void UpdateEmail_Click(object sender, EventArgs e)
        {
            //On lance un appel à la méthode du service permettant de modifier l'utilisateur avec en paramètre le nouvel email et l'ancien
            await this.contactService.UpdateContact(this.contactInfoInput.Text, this.listEmailBox.SelectedItem.ToString());
            //On rafraichit la liste des emails
            this.LoadEmails();
            //On met la textBox à null
            this.contactInfoInput.Text = null;
        }

        /// <summary>
        /// Evenement produit lors d'un click sur le bouton supprimer
        /// </summary>
        public async void DeleteEmail_Click(object sender, EventArgs e)
        {
            //On lance un appel à la méthode du service permettant de suppriler l'utilisateur avec en paramètre l'email
            await this.contactService.DeleteContactByEmail(this.listEmailBox.SelectedItem.ToString());
            //On met la textBox à null
            this.contactInfoInput.Text = null;
            //On rafraichit la liste des emails
            this.LoadEmails();
        }

        public async void ExportEmails_Click(object sender, EventArgs e)
        {
            var contacts = await this.contactService.ContactListByCampagne(this.currentCampagne.Id);
            
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var location = sfd.FileName;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(location + ".txt", true))
                {
                    contacts.ForEach(c =>
                    {
                        file.WriteLine(c.Email);
                    });
                    
                }
            }
        }

        /// <summary>
        /// Evenement produit lors d'un click sur le bouton supprimer doublons
        /// </summary>
        public async void DeleteDuplicate_Click(object sender, EventArgs e)
        {
            //On appel la méthode du service
            await this.contactService.DeleteDuplicate(this.currentCampagne);
            //On rafraichit la liste des emails
            this.LoadEmails();
        }

        public async void SendMail_Click(object sender, EventArgs e)
        {
            var nextForm = new SendMail(this.currentCampagne);
            nextForm.Show();
        }
    }
}
