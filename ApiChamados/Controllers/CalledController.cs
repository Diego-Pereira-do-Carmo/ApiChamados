using ApiChamados.Interfaces.Repository;
using ApiChamados.Interfaces.Service;
using ApiChamados.Models;
using ApiChamados.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ApiChamados.Controllers
{
    [ApiController]
    [Route("api/called")]
    public class CalledController : ControllerBase
    {
        private readonly ICalledService _calledService;
        private readonly ICalledStatusService _calledStatusService;

        public CalledController(ICalledService calledService, ICalledStatusService calledStatusService)
        {
            _calledService = calledService;
            _calledStatusService = calledStatusService;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] CalledViewModel calledViewModel)
        {
            try
            {
                var called = new Called(calledViewModel.Code, calledViewModel.Title, calledViewModel.Description, calledViewModel.StatusId);
                _calledService.Add(called);

                return Ok(new { message = "O chamado foi criado com sucesso." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Ocorreu um erro interno ao processar a solicitação." });
            }
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var CalledList = await _calledService.GetAll();
                return Ok(CalledList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Falha ao buscar os chamados" });
            }
        }

        [HttpDelete]
        [Route("DeleteById")]
        public async Task<IActionResult> DeleteById([FromBody] Guid id)
        {
            try
            {
                if(id == null)
                {
                    return StatusCode(500, new { message = "Falha ao deletar chamados, passe um Id valido" });
                }

                var isDeleted = _calledService.DeleteById(id);
                return Ok(new { message = isDeleted });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Falha ao deletar chamados" });
            }
        }
    }
}
