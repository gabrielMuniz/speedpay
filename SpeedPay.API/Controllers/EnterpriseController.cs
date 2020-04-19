using Microsoft.AspNetCore.Mvc;
using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace SpeedPay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnterpriseController : Controller
    {

        private IEnterpriseService _service;

        public EnterpriseController(IEnterpriseService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Enterprise>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<List<Enterprise>> Get(string id)
        {
            return Ok(_service.GetById(Guid.Parse(id)));
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Enterprise>> Remove(string id)
        {
            var enterprise = _service.GetById(Guid.Parse(id));
            return Ok(_service.Remove(enterprise));
        }

        [HttpPost]
        public ActionResult<List<Enterprise>> Save([FromBody] Enterprise enterprise)
        {
            try
            {
                enterprise.Id = Guid.NewGuid();
                _service.Save(enterprise);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
