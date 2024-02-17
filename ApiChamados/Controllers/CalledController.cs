using ApiChamados.Interfaces;
using ApiChamados.Models;
using ApiChamados.Service.Interfaces;
using ApiChamados.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ApiChamados.Controllers
{
    [ApiController]
    [Route("api/called")]
    public class CalledController : ControllerBase
    {
        private readonly ICalledRepository _calledRepository;
        private readonly ICalledStatusService _calledStatusService;

        public CalledController (ICalledRepository calledRepository, ICalledStatusService calledStatusService)
        {
            _calledRepository = calledRepository;
            _calledStatusService = calledStatusService;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(CalledViewModel calledViewModel)
        {
            var statusList = await _calledStatusService.FindAllAsync();
            var status = statusList.Find(cs => cs.Name == "Aguardando Atendimento").Id;

            var called = new Called(calledViewModel.Code, calledViewModel.Title, calledViewModel.Description, status);
            _calledRepository.Add(called);

            return Ok(called);
        }
    }
}
