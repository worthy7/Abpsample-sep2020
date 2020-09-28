using System.Linq;
using Abp.Application.Editions;
using sep2020.Editions;
using sep2020.EntityFramework;

namespace sep2020.Migrations.SeedData
{
    public class DefaultEditionsCreator
    {
        private readonly sep2020DbContext _context;

        public DefaultEditionsCreator(sep2020DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                //TODO: Add desired features to the standard edition, if wanted!
            }   
        }
    }
}