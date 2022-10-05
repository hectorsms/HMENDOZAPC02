using HMENDOZAPC02.DOMAIN.Core.Entities;
using HMENDOZAPC02.DOMAIN.Core.Interfaces;
using HMENDOZAPC02.DOMAIN.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMENDOZAPC02.DOMAIN.Infraestructure.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly SalesContext _context;

        public SupplierRepository(SalesContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            var suppliers = await _context.Supplier.ToListAsync();
            return suppliers;
        }
        public async Task<Supplier> GetSupplier(int id)
        {
            return await _context.Supplier.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<Supplier>> GetSupplierByCountry(string country)
        {
            var suppliers = await _context.Supplier.Where(x => x.Country == country).ToListAsync();
            return suppliers;
        }

        public async Task<IEnumerable<Supplier>> GetSupplierByCity(string city)
        {
            var suppliers = await _context.Supplier.Where(x => x.City == city).ToListAsync();
            return suppliers;
        }
        public async Task<IEnumerable<Supplier>> GetSupplierByPhone(string phone)
        {
            var suppliers = await _context.Supplier.Where(x => x.Phone == phone).ToListAsync();
            return suppliers;
        }

        public async Task<IEnumerable<Supplier>> GetSupplierByContactName(string ContactName)
        {
            var suppliers = await _context.Supplier.Where(x => x.ContactName == ContactName).ToListAsync();
            return suppliers;
        }


        public async Task<IEnumerable<Supplier>> GetSupplierByCompanyName(string CompanyName)
        {
            var suppliers = await _context.Supplier.Where(x => x.CompanyName == CompanyName).ToListAsync();
            return suppliers;
        }

        public async Task<bool> Insert(Supplier supplier)
        {
            await _context.Supplier.AddAsync(supplier);
            var countrows = await _context.SaveChangesAsync();
            return (countrows > 0);
        }
        public async Task<bool> Update(Supplier supplier)
        {
            _context.Supplier.Update(supplier);
            var countrows = await _context.SaveChangesAsync();
            return (countrows > 0);
        }

        public async Task<bool> Delete(int id)
        {
            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier == null)
                return false;
            _context.Supplier.Remove(supplier);
            var countrows = await _context.SaveChangesAsync();
            return (countrows > 0);
        }

    }


}
