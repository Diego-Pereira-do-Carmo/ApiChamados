using ApiChamados.Interfaces;
using ApiChamados.Models;
using ApiChamados.Service.Interfaces;
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
        public IActionResult Add(CalledStatusViewModel calledStausViewModel)
        {
            var calledStatus = new CalledStatus(calledStausViewModel.Name);
            _calledStatusService.Add(calledStatus);
            return Ok(calledStatus);
        }

        [HttpGet]
        [Route("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var calledStatusList = await _calledStatusService.FindAllAsync();
            return Ok(calledStatusList);
        }
    }
}
