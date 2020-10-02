using Microsoft.EntityFrameworkCore;
using Models;
using Provider.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CampagneService
    {
        private readonly Context context;

        public CampagneService(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Méthode permettant d'ajouter une campagne
        /// </summary>
        public async Task<Campagne> AddCampagne(Campagne newCampagne)
        {
            if (newCampagne == null)
                throw new ArgumentNullException();

            context.Campagne.Add(newCampagne);
            await context.SaveChangesAsync();

            return newCampagne;
        }

        /// <summary>
        /// Méthode permettant de récupérer la liste des campagnes
        /// </summary>
        public async Task<List<Campagne>> ListCampagne()
        {
            var campagnes = await context.Campagne.AsQueryable().ToListAsync();
            return campagnes;
        }

    }
}
