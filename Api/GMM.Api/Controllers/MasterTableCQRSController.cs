using GMM.Application.Handlers.Commands.MasterTableController;
using GMM.Application.Handlers.Queries.MasterTableController;
using GMM.Application.Models;
using GMM.Application.Request.MasterTableController;
using GMM.Application.Response;
using GMM.Common.Excel;
using GMM.Common.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.Table;
using Reec.Helpers;
using Reec.Inspection;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Produces("application/json")]
    public class MasterTableCQRSController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IGenerateExcel _generateExcel;

        public MasterTableCQRSController(IMediator mediator,
                                        IGenerateExcel generateExcel)
        {
            this._mediator = mediator;
            this._generateExcel = generateExcel;
        }

        [HttpGet("FindId/{idMasterTable}")]
        public async Task<IActionResult> FindId(string idMasterTable)
        {
            var result = await _mediator.Send(new QueryFindId(idMasterTable));
            if (result == null)
                throw new ReecException(ReecEnums.Category.PartialContent, "No se encontraron registros");

            return Ok(result);
        }


        [HttpGet("FindAllParent")]
        public async Task<IActionResult> FindAllParent()
        {

            var result = await _mediator.Send(new QueryFindAllParent());
            if (result == null)
                throw new ReecException(ReecEnums.Category.PartialContent, "No se encontraron registros.");

            return Ok(result);
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _mediator.Send(new QueryFindAll());
            if (result != null && result.Count == 0)
                throw new ReecException(ReecEnums.Category.PartialContent, "No se encontraron registros");

            return Ok(result);
        }

        [HttpGet("FindAllAndDownloadExcel")]
        public async Task<IActionResult> FindAllAndDownloadExcel()
        {
            var file = await _mediator.Send(new QueryFindAllAndDownloadExcel());

            return File(file.FileBytes, file.ContentType, file.FileName);


        }


        [HttpGet("FindAllJsonExcel")]
        public async Task<IActionResult> FindAllJsonExcel()
        {

            var list = await _mediator.Send(new QueryFindAllJsonExcel());

            return Ok(list);

        }


        [HttpGet("FindAllByStoreProcedureJsonExcel")]
        public async Task<IActionResult> FindAllByStoreProcedureJsonExcel()
        {
            var exportFile = await _mediator.Send(new QueryFindAllByStoreProcedure());
            return Ok(exportFile);
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create(ModelMasterTable model)
        {
            var result = await _mediator.Send(new CommandCreate(model));
            return Ok(result);
        }

        [HttpPut("Update")]
        //[Produces("application/json")]
        public async Task<IActionResult> Update(ModelMasterTable model)
        {
            var result = await _mediator.Send(new CommandUpdate(model));
            return Ok(result);
        }

        [HttpDelete("Delete/{idMasterTable}")]
        public async Task<IActionResult> Delete(string idMasterTable)
        {
            var result = await _mediator.Send(new CommandDelete(idMasterTable));
            var message = new ReecMessage(ReecEnums.Category.OK, ConstantMessage.DeleteMessage);
            return Ok(message);
        }


        [HttpPost("FindByIdParentAndName")]
        public async Task<IActionResult> FindByIdParentAndName(FindByIdParentAndNameRequest request)
        {
            var result = await _mediator.Send(new QueryFindByIdParentAndName(request));
            return Ok(result);
        }


    }

}
