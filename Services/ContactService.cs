using Microsoft.EntityFrameworkCore;
using Models;
using Provider.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ContactService
    {
        private readonly Context context;

        public ContactService(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Méthode permettant de récupérer un contact par son id
        /// </summary>
        public async Task<Contact> GetContactById(int id)
        {
            return await context.Contact.FirstOrDefaultAsync(u => u.Id == id);
        }

        /// <summary>
        /// Méthode permettant de récupérer un contact par son email
        /// </summary>
        public async Task<Contact> GetContactByEmail(string email)
        {
            return await context.Contact.FirstOrDefaultAsync(u => u.Email == email);
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des contact d'une campagne
        /// </summary>
        public async Task<List<Contact>> ContactListByCampagne(int campagneId)
        {
            var contact = context.Contact.AsQueryable();
            var contacts = await contact.Where(c => c.CampagneId == campagneId).ToListAsync();
            return contacts;
        }

        /// <summary>
        /// Méthode permettant d'ajouter une liste de contact dans une campagne
        /// </summary>
        public async Task AddEmails(Campagne campagne, List<string> emailsList)
        {
            emailsList.ForEach(e =>
            {
                if (!String.IsNullOrEmpty(e))
                {
                    var newContact = new Contact();
                    newContact.Email = e;
                    newContact.CampagneId = campagne.Id;
                    context.Contact.Add(newContact);
                }
            });
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Méthode permettant d'ajouter un contact dans une campagne
        /// </summary>
        public async Task AddEmail(Contact contact)
        {
            context.Contact.Add(contact);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Méthode permettant de mettre à jour un contact
        /// </summary>
        public async Task UpdateContact(string newEmail, string oldEmail)
        {
            var contact = await this.GetContactByEmail(oldEmail);
            contact.Email = newEmail;
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Méthode permettant de supprimer un contact par son email
        /// </summary>
        public async Task DeleteContactByEmail(string email)
        {
            var contact = await this.GetContactByEmail(email);
            context.Contact.Remove(contact);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Méthode permettant de supprimer un contact
        /// </summary>
        public async Task DeleteContact(Contact dContact)
        {
            var contact = await this.GetContactById(dContact.Id);
            context.Contact.Remove(contact);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// Méthode permettant de surpprimer les doublons de contact dans une campagne
        /// </summary>
        public async Task DeleteDuplicate(Campagne campagne)
        {
            var contacts = await this.ContactListByCampagne(campagne.Id);
            
            foreach (var c in contacts)
            {
                var SameEmailList = context.Contact.Where(cc => cc.Email == c.Email).ToList();
                if (SameEmailList.Count != 1)
                {
                    await this.DeleteContact(c);
                }
            }
        }
    }
}
