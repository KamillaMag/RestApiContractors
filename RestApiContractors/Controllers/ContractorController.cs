using LibContractors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RestApiContractors.Controllers
{
    [Route("api/contractors")]
    [ApiController]
    public class ContractorController : ControllerBase
    {
        private readonly IContractorsRepository _contractorsRepository;

        public ContractorController(IContractorsRepository contractorsRepository)
        {
            this._contractorsRepository = contractorsRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Contractor>> Get()
        {
            var contractors = _contractorsRepository.GetAll();
            if (contractors != null)
            {
                return contractors.ToList();
            }

            return  this.NotFound();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(Contractor contractor)
        {
            var id = _contractorsRepository.Create(contractor);
            if (id != (int)Error.AlreadyExist)
            {
                var createdContractor = _contractorsRepository.GetAll().FirstOrDefault(x => x.Id == id);
                return this.Created($"contractors/{id}", createdContractor);
            }
            else
            {
                return this.BadRequest("Such a contractor already exists");
            }
        }
    }
}