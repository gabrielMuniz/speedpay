using Microsoft.AspNetCore.Mvc;
using SpeedPay.Domain.Entities;
using SpeedPay.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace SpeedPay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnterpriseController : Controller
    {

        private IEnterpriseRepository _repository;

        public EnterpriseController(IEnterpriseRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Enterprise>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<List<Enterprise>> Get(string id)
        {
            return Ok(_repository.GetById(Guid.Parse(id)));
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Enterprise>> Remove(string id)
        {
            var enterprise = _repository.GetById(Guid.Parse(id));
            return Ok(_repository.Remove(enterprise));
        }

        [HttpPost]
        public ActionResult<List<Enterprise>> Save([FromBody] Enterprise enterprise)
        {
            try
            {
                enterprise.Id = Guid.NewGuid();
                _repository.Save(enterprise);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
