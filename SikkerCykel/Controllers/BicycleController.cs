using Microsoft.AspNetCore.Mvc;
using SikkerCykel.Interfaces;
using SikkerCykel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SikkerCykel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BicycleController : ControllerBase
    {
        private readonly ILogger<BicycleController> _logger;
        private readonly IFirestoreService _firestoreService;

        public BicycleController(ILogger<BicycleController> logger, IFirestoreService firestoreService)
        {
            _logger = logger;
            _firestoreService = firestoreService;
        }

        // GET api/bicycle
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var bicycles = await _firestoreService.GetAll();
            return Ok(bicycles);
        }

        // POST api/bicycle
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Bicycle bicycle)
        {
            if (bicycle == null)
            {
                return BadRequest("Bicycle is null.");
            }

            await _firestoreService.Add(bicycle);
            return CreatedAtAction(nameof(Get), new { id = bicycle.Id }, bicycle);
        }
    }
}
