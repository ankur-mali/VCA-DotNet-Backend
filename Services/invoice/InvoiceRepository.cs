using VCA.Repositories;
using VCA.Models;
using Microsoft.EntityFrameworkCore;

namespace VCA.Services.Invoices
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly AppDbContext _dbContext;

        public InvoiceRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Dictionary<string, object>>> FindInvoiceByInvoiceIdAsync(int InvoiceId)
        {
            var invoice = await _dbContext.Invoices
                .Include(i => i.Model)
                .Include(i => i.AlternateComponent)
                .Include(i => i.Registration)
                .FirstOrDefaultAsync(i => i.Id == InvoiceId);

            if (invoice != null)
            {
                var invoiceDictionary = new Dictionary<string, object>
                {
                    { "Id", invoice.Id },
                    { "ModelId", invoice.ModelId },
                    { "Model", invoice.Model },
                    { "AltId", invoice.AltCompId },
                    { "AlternateComponent", invoice.AlternateComponent },
                    { "Price", invoice.Price },
                    { "AuthId", invoice.AuthId },
                    { "Registration", invoice.Registration },
                    { "CreatedAt", invoice.CreatedAt },
                    { "UpdatedAt", invoice.UpdatedAt }
                };

                return new List<Dictionary<string, object>> { invoiceDictionary };
            }
            else
            {
                return new List<Dictionary<string, object>>();
            }
        }
    }
}
