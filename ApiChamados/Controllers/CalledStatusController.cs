using ApiChamados.Interfaces;
using ApiChamados.Interfaces.Service;
using ApiChamados.Models;
using ApiChamados.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ApiChamados.Controllers
{
    [ApiController]
    [Route("api/calledStatus")]
    public class CalledStatusController : ControllerBase
    {
        private readonly ICalledStatusService _calledStatusService;

        public CalledStatusController(ICalledStatusService calledStatusService)
        {
            _calledStatusService = calledStatusService;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] CalledStatusViewModel calledStausViewModel)
        {
            var calledStatus = new CalledStatus(calledStausViewModel.Name);
            _calledStatusService.Add(calledStatus);
            return Ok(calledStatus);
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var calledStatusList = await _calledStatusService.GetAll();
            return Ok(calledStatusList);
        }
    }
}
