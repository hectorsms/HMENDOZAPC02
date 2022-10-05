using HMENDOZAPC02.DOMAIN.Core.Entities;

namespace HMENDOZAPC02.DOMAIN.Core.Interfaces
{
    public interface ISupplierRepository
    {
        Task<bool> Delete(int id);
        Task<Supplier> GetSupplier(int id);
        Task<IEnumerable<Supplier>> GetSupplierByCity(string city);
        Task<IEnumerable<Supplier>> GetSupplierByCountry(string country);
        Task<IEnumerable<Supplier>> GetSupplierByPhone(string phone);
        Task<IEnumerable<Supplier>> GetSupplierByContactName(string ContactName);

        Task<IEnumerable<Supplier>> GetSupplierByCompanyName(string CompanyName);

        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<bool> Insert(Supplier supplier);
        Task<bool> Update(Supplier supplier);
    }
}