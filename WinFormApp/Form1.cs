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
    public partial class Form1 : Form
    {
        private readonly Context context;
        private readonly CampagneService campagneService;
        private readonly ContactService contactService;
        public List<Campagne> listCampagne;
        public Form1()
        {
            InitializeComponent();
            this.context = new Context();
            this.campagneService = new CampagneService(this.context);
            this.contactService = new ContactService(this.context);
            this.LoadCampagne();
            
        }

        private async void btnAjouterCampagne_Click(object sender, EventArgs e)
        {
            var newCampagne = new Campagne();
            newCampagne.Name = this.textBoxNomCampagne.Text;
            await this.campagneService.AddCampagne(newCampagne);
            this.textBoxNomCampagne.Text = null;
        }

        private async void listBoxEmailCampagne_Click(object sender, EventArgs e)
        {
            var i = this.listBoxEmailCampagne.SelectedIndex;
            var selectedCampagne = this.listCampagne[i];
            this.LoadContact(selectedCampagne.Id);
        }

        public async void LoadCampagne()
        {
            this.listCampagne = await this.campagneService.ListCampagne();
            listCampagne.ForEach(c =>
            {
                this.listBoxEmailCampagne.Items.Add(c.Name);
            });
        }

        public async void LoadContact(int campagneId)
        {
            var contacts = await contactService.ContactListByCampagne(campagneId);
            this.listEmailCampagne = new ListBox();
            contacts.ForEach(c =>
            {
                this.listEmailCampagne.Items.Add(c.ToString());
            });
        }
    }
}
