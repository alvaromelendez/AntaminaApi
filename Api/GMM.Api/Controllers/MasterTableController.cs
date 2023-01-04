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
        public async Task<IActionResult> FindId(int idMasterTable)
        {
            //var result = await _masterTableRepository.FindId(idMasterTable);
            //return Ok(result);

            switch ((MasterTableType)idMasterTable)
            {
                case MasterTableType.NotificationCLass:
                    return Ok(GetModelNotificeClass());
                case MasterTableType.PlanificationGroup:
                    return Ok(GetModelPlanificationGroup());
                case MasterTableType.JobPosition:
                    return Ok(GetModelJobPosition());
                case MasterTableType.Priority:
                    return Ok(GetModelPriority());
                case MasterTableType.Fault:
                    return Ok(GetModelFault());
                case MasterTableType.Cause:
                    return Ok(GetModelCause());
                case MasterTableType.Activity:
                    return Ok(GetModelActivity());
                case MasterTableType.SymptomFault:
                    return Ok(GetModelSymptomFault());
                case MasterTableType.SystemStatus:
                    return Ok(GetModelSystemStatus());
                default:
                    break;
            }
            return BadRequest();
        }
        private List<ModelNotificeClassMaster> GetModelNotificeClass()
        {
            string data = @"[{""Key"":""MI"",""Description"":""Mnto. Imprevisto""},{""Key"":""MN"",""Description"":""Mnto. Normal""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelNotificeClassMaster>>(data);
        }
        private List<ModelPlanificationGroupMaster> GetModelPlanificationGroup()
        {
            string data = @"[{""Code"":""CAM"",""Description"":""MANTENIMIENTO CAMIONES"",""Center"":""1101""},{""Code"":""PAL"",""Description"":""MANTENIMIENTO PALAS&PERFORADORAS"",""Center"":""1101""},{""Code"":""AUX"",""Description"":""MANTENIMIENTO AUXILIARES"",""Center"":""1101""},{""Code"":""LIV"",""Description"":""MANTENIMIENTO SOPORTE LIVIANOS"",""Center"":""1101""},{""Code"":""MOL"",""Description"":""MOLIENDA"",""Center"":""1101""},{""Code"":""FLO"",""Description"":""FLOTACION"",""Center"":""1101""},{""Code"":""CHA"",""Description"":""CHANCADO"",""Center"":""1101""},{""Code"":""ELE"",""Description"":""ELECTRICIDAD"",""Center"":""1101""},{""Code"":""INS"",""Description"":""INSTRUMENTACION"",""Center"":""1101""},{""Code"":""MOB"",""Description"":""RELAVES FLOTACION BISMUTO MOLI"",""Center"":""1101""},{""Code"":""SE1"",""Description"":""SERVICIOS MINA"",""Center"":""1101""},{""Code"":""SE2"",""Description"":""SERVICIOS PUERTO"",""Center"":""1102""},{""Code"":""PUE"",""Description"":""MANTENIMIENTO PUERTO"",""Center"":""1102""},{""Code"":""LI1"",""Description"":""LINEAS AEREAS AT MINA"",""Center"":""1101""},{""Code"":""LI2"",""Description"":""LINEAS AEREAS AT PUERTO"",""Center"":""1102""},{""Code"":""PO1"",""Description"":""SISTEMA POTENCIA MINA"",""Center"":""1101""},{""Code"":""PO2"",""Description"":""SISTEMA POTENCIA PUERTO"",""Center"":""1102""},{""Code"":""ELM"",""Description"":""ELECTRICIDAD MINA"",""Center"":""1101""},{""Code"":""MIS"",""Description"":""MISCELANEOS"",""Center"":""1101""},{""Code"":""MP1"",""Description"":""MANTENIMIENTO MINERODUCTO MINA"",""Center"":""1101""},{""Code"":""MP2"",""Description"":""MANTENIMIENTO MINERODUCTO PUERTO"",""Center"":""1102""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelPlanificationGroupMaster>>(data);
        }
        private List<ModelJobPositionMaster> GetModelJobPosition()
        {
            string data = @"[{""Code"":""PREMIN"",""Description"":""Predictivo Mina"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""AUX""},{""Code"":""MECARGA"",""Description"":""Tecnicos de equipos auxiliares"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""AUX""},{""Code"":""MECAMIO"",""Description"":""Tecnicos de camiones"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""CAM""},{""Code"":""MELVLV"",""Description"":""Tecnicos de equipos livianos"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""LIV""},{""Code"":""MPALAS"",""Description"":""Tecnicos de palas & perforadoras"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""PAL""},{""Code"":""MLLANTA"",""Description"":""Tecnicos de Llantas"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""CAM""},{""Code"":""TECPHIT"",""Description"":""Tecnicos Palas Hidraulicas Hitachi"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""PAL""},{""Code"":""SSEER&I"",""Description"":""R&I Componentes SSEE"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""PAL""},{""Code"":""SSEESOL"",""Description"":""Soldadores SSEE"",""Manager"":""MIM"",""Center"":1101,""PlanificationGroup"":""PAL""},{""Code"":""ELECON"",""Description"":""Electricidad concentradora"",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""ELE""},{""Code"":""MECFLO"",""Description"":""Mecanicos de flotacion"",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""FLO""},{""Code"":""MECMOB"",""Description"":""Mecanicos flotacion mo-bi"",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""MOB""},{""Code"":""MECMOL"",""Description"":""Mecanicos de molienda"",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""MOL""},{""Code"":""INSCON"",""Description"":""Instrumentista concentradora"",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""INS""},{""Code"":""INSSER"",""Description"":""Instrumentacion chancado  "",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""INS""},{""Code"":""MECCHA"",""Description"":""Mecanicos de chancadora"",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""CHA""},{""Code"":""PRECON"",""Description"":""Predictivo de Concentradora"",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""CHA""},{""Code"":""PROCON"",""Description"":""Control de Proceso Concentradora"",""Manager"":""MCO"",""Center"":1101,""PlanificationGroup"":""INS""},{""Code"":""OPESER"",""Description"":""Operador equipos servicios"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MECCMP"",""Description"":""Compresores    "",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1 SE2""},{""Code"":""MECPMP"",""Description"":""Mantenimiento Bombas"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MECAAC"",""Description"":""Aire acondicionado"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1 SE2""},{""Code"":""MECGPT"",""Description"":""Gruas puente y aux      "",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1 SE2""},{""Code"":""MECCST"",""Description"":""Planta de agregados"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MECASP"",""Description"":""Sistema aspersion"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MECSER"",""Description"":""Mantenimiento Servicios"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MECPWP"",""Description"":""Plantas de agua servicios"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MANCAR"",""Description"":""Mantenimiento Carreteras"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MANEDF"",""Description"":""Mantenimiento Edificaciones"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MECAUX"",""Description"":""Mantenimiento Equipos auxiliares"",""Manager"":""SER"",""Center"":1101,""PlanificationGroup"":""SE1""},{""Code"":""MECPUE"",""Description"":""Mecanico Puerto"",""Manager"":""MPU"",""Center"":1102,""PlanificationGroup"":""PUE""},{""Code"":""ELEPUE"",""Description"":""Electricista Puerto"",""Manager"":""MPU"",""Center"":1102,""PlanificationGroup"":""PUE""},{""Code"":""INSPUE"",""Description"":""Instrumentista Puerto"",""Manager"":""MPU"",""Center"":1102,""PlanificationGroup"":""PUE""},{""Code"":""PREPUE"",""Description"":""Predictivo Puerto"",""Manager"":""MPU"",""Center"":1102,""PlanificationGroup"":""PUE""},{""Code"":""ELELIN"",""Description"":""Electricista Liniero"",""Manager"":""SIP"",""Center"":1101,""PlanificationGroup"":""LI1 LI2""},{""Code"":""ELEPOT"",""Description"":""Electricista  Sistema Potencia"",""Manager"":""SIP"",""Center"":1101,""PlanificationGroup"":""PO1 PO2""},{""Code"":""ELEMIN"",""Description"":""Electricista Mina"",""Manager"":""SIP"",""Center"":1101,""PlanificationGroup"":""ELM""},{""Code"":""ELEMIS"",""Description"":""Electricista Miscelaneos"",""Manager"":""SIP"",""Center"":1101,""PlanificationGroup"":""MIS""},{""Code"":""MINMEC"",""Description"":""Mecanico Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1 MP1""},{""Code"":""MINELE"",""Description"":""Electricista Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1 MP1""},{""Code"":""MININS"",""Description"":""Instrumentista Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1 MP1""},{""Code"":""MININT"",""Description"":""Integridad Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1 MP1""},{""Code"":""MINOPE"",""Description"":""Operadores Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1""},{""Code"":""MINMCO"",""Description"":""Monitoreo de Condicion Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1 MP2""},{""Code"":""MINDDV"",""Description"":""Derecho de Via Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1 MP2""},{""Code"":""MINPCA"",""Description"":""Proteccion Catodica Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1 MP2""},{""Code"":""MINMIN"",""Description"":""Mantenimiento Integral Mineroducto"",""Manager"":""MMI"",""Center"":1101,""PlanificationGroup"":""MP1 MP2""},{""Code"":""SSEEMIN"",""Description"":""Socios Estrategicos Mina"",""Manager"":""SES"",""Center"":1101,""PlanificationGroup"":""MP1 MP2""},{""Code"":""SSEEPUE"",""Description"":""Socios Estrategicos Puerto"",""Manager"":""SES"",""Center"":1102,""PlanificationGroup"":""MP1 MP2""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelJobPositionMaster>>(data);
        }
        private List<ModelPriorityMaster> GetModelPriority()
        {
            string data = @"[{""Key"":""0"",""Description"":""Inmediato""},{""Key"":""1"",""Description"":""Prog. Interrumpido""},{""Key"":""2"",""Description"":""Proximo Programa""},{""Key"":""3"",""Description"":""Prox. Oportunidad""},{""Key"":""4"",""Description"":""Parada""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelPriorityMaster>>(data);
        }
        private List<ModelFaultMaster> GetModelFault()
        {
            string data = @"[{""ObjectPart"":""PM1"",""key"":1,""Description"":""Parte Objeto 1""},{""ObjectPart"":""PM1"",""key"":2,""Description"":""Parte Objeto 2""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelFaultMaster>>(data);
        }
        private List<ModelSymptomFaultMaster> GetModelSymptomFault()
        {
            string data = @"[{""SymptomFault"":""PM1"",""Key"":""1"",""Description"":""Sintoma avería 1""},{""SymptomFault"":""PM1"",""Key"":""2"",""Description"":""Sintoma avería 2""},{""SymptomFault"":""PM2"",""Key"":""A"",""Description"":""Sintoma avería A""},{""SymptomFault"":""PM2"",""Key"":""B"",""Description"":""Sintoma avería B""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelSymptomFaultMaster>>(data);
        }
        private List<ModelCauseMaster> GetModelCause()
        {
            string data = @"[{""Cause"":""PM1"",""Key"":1,""Description"":""Causa 1""},{""Cause"":""PM1"",""Key"":2,""Description"":""Causa 2""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelCauseMaster>>(data);
        }
        private List<ModelActivityMaster> GetModelActivity()
        {
            string data = @"[{""Activity"":""PM1"",""Key"":1,""Description"":""Actividad 1""},{""Activity"":""PM1"",""Key"":2,""Description"":""Actividad 2""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelActivityMaster>>(data);
        }
        private List<ModelNotificeClassMaster> GetModelSystemStatus()
        {
            string data = @"[{""Key"":""MEAB"",""Description"":""Mensaje abierto""},{""Key"":""METR"",""Description"":""Mensaje de tratamiento""},{""Key"":""ORAS"",""Description"":""Orden asignada""},{""Key"":""MECE"",""Description"":""Mensaje cerrado""}]";
            return System.Text.Json.JsonSerializer.Deserialize<List<ModelNotificeClassMaster>>(data);
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

    public enum MasterTableType
    {
        NotificationCLass,
        PlanificationGroup,
        JobPosition,
        Priority,
        Fault,
        Cause,
        Activity,
        SymptomFault,
        SystemStatus
    }
}
