using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GMM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterTableController : ControllerBase
    {
        private readonly IMasterTableRepository _masterTableRepository;
        private readonly IMapper _mapper;

        public MasterTableController(IMasterTableRepository masterTableRepository, IMapper mapper)
        {
            this._masterTableRepository = masterTableRepository;
            this._mapper = mapper;
        }

        [HttpGet("FindId/{idMasterTable}")]
        public async Task<IActionResult> FindId(string idMasterTable)
        {
            var result = await _masterTableRepository.FindId(idMasterTable);
            return Ok(result);
        }

        [HttpGet("FindAll")]
        public async Task<IActionResult> FindAll()
        {
            var result = await _masterTableRepository.FindAll();
            return Ok(result);
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create(ModelMasterTable model)
        {
            var entity = _mapper.Map<MasterTable>(model);
            entity.RecordCreationDate = DateTime.Now;

            await _masterTableRepository.Create(entity);
            var result = _mapper.Map<ModelMasterTable>(entity);

            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(ModelMasterTable model)
        {

            var entity = _mapper.Map<MasterTable>(model);
            entity.RecordEditDate = DateTime.Now;
            await _masterTableRepository.Update(entity);
            var result = _mapper.Map<ModelMasterTable>(entity);

            return Ok(result);
        }

        [HttpDelete("Delete/{idMasterTable}")]
        public async Task<IActionResult> Delete(string idMasterTable)
        {
            await _masterTableRepository.Delete(idMasterTable);
            return Ok(true);
        }




    }

}
