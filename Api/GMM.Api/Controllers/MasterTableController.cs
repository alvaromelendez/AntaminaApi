using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml.Utils;

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
            //var result = await _masterTableRepository.FindId(idMasterTable);
            //return Ok(result);

            switch (idMasterTable)
            {
                case "Clase de aviso":
                    return Ok(GetModelNotificeClass());
                case "Grupo Planificacion":
                    return Ok(GetModelPlanificationGroup());
                case "Puestos de trabajo":
                    return Ok(GetModelJobPosition());
                case "Prioridad":
                    return Ok(GetModelPriority());
                case "Averia":
                    return Ok(GetModelFaultt());
                case "Causa":
                    return Ok(GetModelCausaa());
                case "Actividad":
                    return Ok(GetModelActivityy());
                default:
                    break;
            }
            return BadRequest();
        }
        private List<ModelNotificeClass> GetModelNotificeClass()
        {
            string data = @"[{""KEY"":""MI"",""DESCRIPTION"":""Mnto. Imprevisto""},{""KEY"":""MN"",""DESCRIPTION"":""Mnto. Normal""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelNotificeClass>>(data);
        }
        private List<ModelPlanificationGroup> GetModelPlanificationGroup()
        {
            string data = @"[{""CODIGO"":""CAM"",""DESCRIPCION"":""MANTENIMIENTO CAMIONES"",""CENTRO"":""1101""},{""CODIGO"":""PAL"",""DESCRIPCION"":""MANTENIMIENTO PALAS&PERFORADORAS"",""CENTRO"":""1101""},{""CODIGO"":""AUX"",""DESCRIPCION"":""MANTENIMIENTO AUXILIARES"",""CENTRO"":""1101""},{""CODIGO"":""LIV"",""DESCRIPCION"":""MANTENIMIENTO SOPORTE LIVIANOS"",""CENTRO"":""1101""},{""CODIGO"":""MOL"",""DESCRIPCION"":""MOLIENDA"",""CENTRO"":""1101""},{""CODIGO"":""FLO"",""DESCRIPCION"":""FLOTACION"",""CENTRO"":""1101""},{""CODIGO"":""CHA"",""DESCRIPCION"":""CHANCADO"",""CENTRO"":""1101""},{""CODIGO"":""ELE"",""DESCRIPCION"":""ELECTRICIDAD"",""CENTRO"":""1101""},{""CODIGO"":""INS"",""DESCRIPCION"":""INSTRUMENTACION"",""CENTRO"":""1101""},{""CODIGO"":""MOB"",""DESCRIPCION"":""RELAVES FLOTACION BISMUTO MOLI"",""CENTRO"":""1101""},{""CODIGO"":""SE1"",""DESCRIPCION"":""SERVICIOS MINA"",""CENTRO"":""1101""},{""CODIGO"":""SE2"",""DESCRIPCION"":""SERVICIOS PUERTO"",""CENTRO"":""1102""},{""CODIGO"":""PUE"",""DESCRIPCION"":""MANTENIMIENTO PUERTO"",""CENTRO"":""1102""},{""CODIGO"":""LI1"",""DESCRIPCION"":""LINEAS AEREAS AT MINA"",""CENTRO"":""1101""},{""CODIGO"":""LI2"",""DESCRIPCION"":""LINEAS AEREAS AT PUERTO"",""CENTRO"":""1102""},{""CODIGO"":""PO1"",""DESCRIPCION"":""SISTEMA POTENCIA MINA"",""CENTRO"":""1101""},{""CODIGO"":""PO2"",""DESCRIPCION"":""SISTEMA POTENCIA PUERTO"",""CENTRO"":""1102""},{""CODIGO"":""ELM"",""DESCRIPCION"":""ELECTRICIDAD MINA"",""CENTRO"":""1101""},{""CODIGO"":""MIS"",""DESCRIPCION"":""MISCELANEOS"",""CENTRO"":""1101""},{""CODIGO"":""MP1"",""DESCRIPCION"":""MANTENIMIENTO MINERODUCTO MINA"",""CENTRO"":""1101""},{""CODIGO"":""MP2"",""DESCRIPCION"":""MANTENIMIENTO MINERODUCTO PUERTO"",""CENTRO"":""1102""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelPlanificationGroup>>(data);
        }
        private List<ModelJobPosition> GetModelJobPosition()
        {
            string data = @"[{""CODIGO"":""PREMIN"",""DESCRIPCION"":""Predictivo Mina"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""AUX""},{""CODIGO"":""MECARGA"",""DESCRIPCION"":""Tecnicos de equipos auxiliares"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""AUX""},{""CODIGO"":""MECAMIO"",""DESCRIPCION"":""Tecnicos de camiones"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""CAM""},{""CODIGO"":""MELVLV"",""DESCRIPCION"":""Tecnicos de equipos livianos"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""LIV""},{""CODIGO"":""MPALAS"",""DESCRIPCION"":""Tecnicos de palas & perforadoras"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""PAL""},{""CODIGO"":""MLLANTA"",""DESCRIPCION"":""Tecnicos de Llantas"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""CAM""},{""CODIGO"":""TECPHIT"",""DESCRIPCION"":""Tecnicos Palas Hidraulicas Hitachi"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""PAL""},{""CODIGO"":""SSEER&I"",""DESCRIPCION"":""R&I Componentes SSEE"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""PAL""},{""CODIGO"":""SSEESOL"",""DESCRIPCION"":""Soldadores SSEE"",""RESPONSABLE"":""MIM"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""PAL""},{""CODIGO"":""ELECON"",""DESCRIPCION"":""Electricidad concentradora"",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""ELE""},{""CODIGO"":""MECFLO"",""DESCRIPCION"":""Mecanicos de flotacion"",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""FLO""},{""CODIGO"":""MECMOB"",""DESCRIPCION"":""Mecanicos flotacion mo-bi"",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MOB""},{""CODIGO"":""MECMOL"",""DESCRIPCION"":""Mecanicos de molienda"",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MOL""},{""CODIGO"":""INSCON"",""DESCRIPCION"":""Instrumentista concentradora"",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""INS""},{""CODIGO"":""INSSER"",""DESCRIPCION"":""Instrumentacion chancado  "",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""INS""},{""CODIGO"":""MECCHA"",""DESCRIPCION"":""Mecanicos de chancadora              "",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""CHA""},{""CODIGO"":""PRECON"",""DESCRIPCION"":""Predictivo de Concentradora     "",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""CHA""},{""CODIGO"":""PROCON"",""DESCRIPCION"":""Control de Proceso Concentradora"",""RESPONSABLE"":""MCO"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""INS""},{""CODIGO"":""OPESER"",""DESCRIPCION"":""Operador equipos servicios"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MECCMP"",""DESCRIPCION"":""Compresores    "",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1 SE2""},{""CODIGO"":""MECPMP"",""DESCRIPCION"":""Mantenimiento Bombas"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MECAAC"",""DESCRIPCION"":""Aire acondicionado"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1 SE2""},{""CODIGO"":""MECGPT"",""DESCRIPCION"":""Gruas puente y aux      "",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1 SE2""},{""CODIGO"":""MECCST"",""DESCRIPCION"":""Planta de agregados"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MECASP"",""DESCRIPCION"":""Sistema aspersion"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MECSER"",""DESCRIPCION"":""Mantenimiento Servicios"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MECPWP"",""DESCRIPCION"":""Plantas de agua servicios"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MANCAR"",""DESCRIPCION"":""Mantenimiento Carreteras"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MANEDF"",""DESCRIPCION"":""Mantenimiento Edificaciones"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MECAUX"",""DESCRIPCION"":""Mantenimiento Equipos auxiliares"",""RESPONSABLE"":""SER"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""SE1""},{""CODIGO"":""MECPUE"",""DESCRIPCION"":""Mecanico Puerto"",""RESPONSABLE"":""MPU"",""CENTRO"":1102,""GRUPOPLANIFICACION"":""PUE""},{""CODIGO"":""ELEPUE"",""DESCRIPCION"":""Electricista Puerto"",""RESPONSABLE"":""MPU"",""CENTRO"":1102,""GRUPOPLANIFICACION"":""PUE""},{""CODIGO"":""INSPUE"",""DESCRIPCION"":""Instrumentista Puerto"",""RESPONSABLE"":""MPU"",""CENTRO"":1102,""GRUPOPLANIFICACION"":""PUE""},{""CODIGO"":""PREPUE"",""DESCRIPCION"":""Predictivo Puerto"",""RESPONSABLE"":""MPU"",""CENTRO"":1102,""GRUPOPLANIFICACION"":""PUE""},{""CODIGO"":""ELELIN"",""DESCRIPCION"":""Electricista Liniero"",""RESPONSABLE"":""SIP"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""LI1 LI2""},{""CODIGO"":""ELEPOT"",""DESCRIPCION"":""Electricista  Sistema Potencia"",""RESPONSABLE"":""SIP"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""PO1 PO2""},{""CODIGO"":""ELEMIN"",""DESCRIPCION"":""Electricista Mina"",""RESPONSABLE"":""SIP"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""ELM""},{""CODIGO"":""ELEMIS"",""DESCRIPCION"":""Electricista Miscelaneos"",""RESPONSABLE"":""SIP"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MIS""},{""CODIGO"":""MINMEC"",""DESCRIPCION"":""Mecanico Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP1""},{""CODIGO"":""MINELE"",""DESCRIPCION"":""Electricista Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP1""},{""CODIGO"":""MININS"",""DESCRIPCION"":""Instrumentista Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP1""},{""CODIGO"":""MININT"",""DESCRIPCION"":""Integridad Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP1""},{""CODIGO"":""MINOPE"",""DESCRIPCION"":""Operadores Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1""},{""CODIGO"":""MINMCO"",""DESCRIPCION"":""Monitoreo de Condicion Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP2""},{""CODIGO"":""MINDDV"",""DESCRIPCION"":""Derecho de Via Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP2""},{""CODIGO"":""MINPCA"",""DESCRIPCION"":""Proteccion Catodica Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP2""},{""CODIGO"":""MINMIN"",""DESCRIPCION"":""Mantenimiento Integral Mineroducto"",""RESPONSABLE"":""MMI"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP2""},{""CODIGO"":""SSEEMIN"",""DESCRIPCION"":""Socios Estrategicos Mina"",""RESPONSABLE"":""SES"",""CENTRO"":1101,""GRUPOPLANIFICACION"":""MP1 MP2""},{""CODIGO"":""SSEEPUE"",""DESCRIPCION"":""Socios Estrategicos Puerto"",""RESPONSABLE"":""SES"",""CENTRO"":1102,""GRUPOPLANIFICACION"":""MP1 MP2""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelJobPosition>>(data);
        }
        private List<ModelPriority> GetModelPriority()
        {
            string data = @"[{""KEY"":""0"",""DESCRIPTION"":""Inmediato""},{""KEY"":""1"",""DESCRIPTION"":""Prog. Interrumpido""},{""KEY"":""2"",""DESCRIPTION"":""Proximo Programa""},{""KEY"":""3"",""DESCRIPTION"":""Prox. Oportunidad""},{""KEY"":""4"",""DESCRIPTION"":""Parada""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelPriority>>(data);
        }
        private List<ModelFaultt> GetModelFaultt()
        {
            string data = @"[{""Parte Objeto"":""PM1"",""key"":1,""Description"":""Parte Objeto 1""},{""Parte Objeto"":""PM1"",""key"":2,""Description"":""Parte Objeto 2""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelFaultt>>(data);
        }
        private List<ModelCausaa> GetModelCausaa()
        {
            string data = @"[{""Causa"":""PM1"",""Key"":1,""Description"":""Causa 1""},{""Causa"":""PM1"",""Key"":2,""Description"":""Causa 2""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelCausaa>>(data);
        }
        private List<ModelActivityy> GetModelActivityy()
        {
            string data = @"[{""Actividad"":""PM1"",""Key"":1,""Description"":""Actividad 1""},{""Actividad"":""PM1"",""Key"":2,""Description"":""Actividad 2""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelActivityy>>(data);
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
