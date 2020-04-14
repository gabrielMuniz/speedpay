using Microsoft.AspNetCore.Mvc;
using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace SpeedPay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : Controller
    {

        private IProviderRepository providerRepository;

        public ProviderController(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
        }

        [HttpGet]
        public ActionResult<List<Provider>> GetAll()
        {
            return Ok(providerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<List<Provider>> Get(string id)
        {
            return Ok(providerRepository.GetById(Guid.Parse(id)));
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Provider>> Remove(string id)
        {
            var provider = providerRepository.GetById(Guid.Parse(id));
            return Ok(providerRepository.Remove(provider));
        }

        [HttpPost]
        public ActionResult<List<Provider>> Save([FromBody] Provider provider)
        {
            try
            {
                provider.Id = Guid.NewGuid();
                provider.CreatedAt = DateTime.Now;
                providerRepository.Save(provider);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}