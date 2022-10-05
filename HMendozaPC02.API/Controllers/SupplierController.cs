using HMENDOZAPC02.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;

namespace HMendozaPC02.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var supplier = await _supplierRepository.GetSuppliers();
            return Ok(supplier);
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetSuppliersById(int id)
        {
            var supplier = await _supplierRepository.GetSupplier(id);
            return Ok(supplier);

        }

        [HttpGet("GetByCountry/{country}")]

        public async Task<IActionResult> GetByCountry(string country)
        {
            var supplier = await _supplierRepository.GetSupplierByCountry(country);
            return Ok(supplier);

        }

        [HttpGet("GetByCity/{city}")]

        public async Task<IActionResult> GetByCity(string city)
        {
            var supplier = await _supplierRepository.GetSupplierByCity(city);
            return Ok(supplier);

        }

        [HttpGet("GetByPhone/{phone}")]

        public async Task<IActionResult> GetByPhone(string phone)
        {
            var supplier = await _supplierRepository.GetSupplierByPhone(phone);
            return Ok(supplier);

        }

        [HttpGet("ContactName/{ContactName}")]

        public async Task<IActionResult> GetByContactName( string ContactName)
        {
            var supplier = await _supplierRepository.GetSupplierByContactName(ContactName);
            return Ok(supplier);

        }

        [HttpGet("CompanyName/{CompanyName}")]

        public async Task<IActionResult> GetByCompanyName(string CompanyName)
        {
            var supplier = await _supplierRepository.GetSupplierByCompanyName(CompanyName);
            return Ok(supplier);

        }


    }
}
