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
    public partial class SendMail : Form
    {
        private readonly Context context;

        public Models.Campagne currentCampagne;
        public SendMail(Models.Campagne campagneSelected, string emailSelected)
        {
            //Définition du context
            this.context = new Context();
            InitializeComponent();

            //On récupère les valeurs transmises en paramètre
            this.currentCampagne = campagneSelected;
            this.expInput.Text = emailSelected;
        }

        public SendMail(Models.Campagne campagneSelected)
        {
            //On récupère les valeurs transmises en paramètre
            this.currentCampagne = campagneSelected;
            //Définition du context
            this.context = new Context();
            //On initialise les composant qui seront affichés
            InitializeComponent();
        }
        /// <summary>
        /// Méthode appelé au clique sur le bouton "envoyer"
        /// </summary>
        public void SendMail_Click(object sender, EventArgs e)
        {
            //On vérifie si il faut envoyer à toute la campagne ou seulement à un email en particulier
            if (this.allCheckBox.Checked)
            {
                //On vérifie que les champs ne soit pas vide
                if (!String.IsNullOrEmpty(this.msgInput.Text)
                    && !String.IsNullOrEmpty(this.objInput.Text))
                {
                    //On ouvre la prochaine fenêtre
                    var nextForm = new Setting(this.currentCampagne, this.expInput.Text, this.objInput.Text, this.msgInput.Text, this.allCheckBox.Checked);
                    nextForm.Show();

                }
            }
            else
            {
                //On vérifie que les champs ne soit pas vide
                if (!String.IsNullOrEmpty(this.msgInput.Text)
               && !String.IsNullOrEmpty(this.objInput.Text)
               && !String.IsNullOrEmpty(this.expInput.Text))
                {
                    //On ouvre la prochaine fenêtre
                    var nextForm = new Setting(this.currentCampagne, this.expInput.Text, this.objInput.Text, this.msgInput.Text, this.allCheckBox.Checked);
                    nextForm.Show();
                }
            }
            //On ferme la fenêtre courrante
            this.Hide();
        }

        /// <summary>
        /// Méthiode appelé au clique sur la checkbox
        /// </summary>
        public void Checkbox_Click(object sender, EventArgs e)
        {
            //On met le champs du destinataire à null
            this.expInput.Text = null;
            //On active ou non le champs selon l'état de la checkbox (true/false)
            this.expInput.Enabled = !this.expInput.Enabled;
        }
    }
}
