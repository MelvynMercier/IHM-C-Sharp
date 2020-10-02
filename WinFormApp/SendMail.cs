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
        public SendMail(Models.Campagne campagneSelected)
        {
            //Définition du context
            this.context = new Context();
            InitializeComponent();
        }

        public async void SendMail_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.msgInput.Text)
                && !String.IsNullOrEmpty(this.objInput.Text)
                && !String.IsNullOrEmpty(this.expInput.Text))
            {
                //TODO : Créer fenêtre paramêtre smtp
            }
        }
    }
}
