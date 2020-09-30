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
    public partial class Home : Form
    {
        public Home()
        {
            //Initialisation des composants
            InitializeComponent();
        }

        /// <summary>
        /// Méthode permettant d'ouvrir la prochaine fenêtre
        /// </summary>
        private async void nextIHM_Click(object sender, EventArgs e)
        {
            var nextForm = new Campagne();
            nextForm.Show();
        }

    }
}
