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

        public async Task<Contact> GetContactById(int id)
        {
            return await context.Contact.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<Contact> GetContactByEmail(string email)
        {
            return await context.Contact.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<List<Contact>> ContactListByCampagne(int campagneId)
        {
            var contact = context.Contact.AsQueryable();
            return await contact.Where(c => c.CampagneId == campagneId).ToListAsync();
        }
    }
}
