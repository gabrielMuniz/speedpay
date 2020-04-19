using Microsoft.AspNetCore.Mvc;
using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using SpeedPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SpeedPay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : Controller
    {

        private IProviderService _service;

        public ProviderController(IProviderService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Provider>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<List<Provider>> Get(string id)
        {
            return Ok(_service.GetById(Guid.Parse(id)));
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Provider>> Remove(string id)
        {
            var provider = _service.GetById(Guid.Parse(id));
            return Ok(_service.Remove(provider));
        }

        [HttpPost]
        public ActionResult<List<Provider>> Save([FromBody] Provider provider)
        {
            try
            {
                provider.Id = Guid.NewGuid();
                provider.CreatedAt = DateTime.Now;
                _service.Save(provider);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}