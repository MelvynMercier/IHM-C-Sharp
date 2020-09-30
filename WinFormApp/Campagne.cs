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
    public partial class Campagne : Form
    {
        private readonly Context context;
        private readonly CampagneService campagneService;
        public List<Models.Campagne> listCampagne;
        public Campagne()
        {
            //Définition du context
            this.context = new Context();
            //Définition du service
            this.campagneService = new CampagneService(this.context);
            //Initialisation des composants
            InitializeComponent();
            //Appel de la méthode LoadCampagne
            this.LoadCampagne();
            
        }

        /// <summary>
        /// Evenement produit lors du clique sur le bouton "ajouter une campagne"
        /// </summary>
        private async void AddCampagne_Click(object sender, EventArgs e)
        {
            //Déclaration d"un nouvel objet Campagne, vide
            var newCampagne = new Models.Campagne();
            //Le nom de la campagne saisie est ajouté à la campagne précédemment crée
            newCampagne.Name = this.inputName.Text;
            //Appel au service permettant de créer une campagne
            await this.campagneService.AddCampagne(newCampagne);
            //Le champs de saisie est remit à null
            this.inputName.Text = null;
            //On charge de nouveau les campagnes
            this.LoadCampagne();
        }        
        
        /// <summary>
        /// Evenement produit lors d'un click sur une ligne de la liste des campagnes
        /// </summary>
        private async void OpenIHMCampagne_Click(object sender, EventArgs e)
        {
            //On récupère l'index selectionné
            var index = this.listBoxEmailCampagne.SelectedIndex;
            //On récupère la campagne selon l'index précedemment récupérer
            var campagneSelected = this.listCampagne[index];
            //On ouvre une nouvelle fenêtre avec en paramètre la campagne récupérée
            var nextForm = new CampagneDetails(campagneSelected);
            nextForm.Show();
        }

        /// <summary>
        /// Méthode permettant de charger toutes les campagnes
        /// </summary>
        public async void LoadCampagne()
        {
            //On vide toutes les campagnes de la variable listBoxEmailCampagne
            this.listBoxEmailCampagne.Items.Clear();
            //On récupère toute les campagnes
            this.listCampagne = await this.campagneService.ListCampagne();
            //On boucle sur la liste des campagnes récupèrée
            listCampagne.ForEach(c =>
            {
                //On ajoute le nom des campagnes dans la listBox "listBoxEmailCampagne"
                this.listBoxEmailCampagne.Items.Add(c.Name);
            });
        }
    }
}
