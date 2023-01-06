using AutoMapper;
using GMM.Application.Interfaces.Repositories;
using GMM.Application.Models;
using GMM.Domain.Entities;
using GMM.Infrastructure.Repositories;
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
        private readonly INotificationClassRepository _notificationClassRepository;
        private readonly IPlanningGroupRepository _planningGroupRepository;
        private readonly IJobPositionRepository _jobPositionRepository;
        private readonly IPriorityRepository _priorityRepository;
        private readonly ICauseRepository _causeRepository;
        private readonly IActivityRepository _activityRepository;
        private readonly IFaultRepository _faultRepository;
        private readonly ISymptomFaultRepository _symptomFaultRepository;
        public MasterTableController(INotificationClassRepository notificationClassRepository,
            IPlanningGroupRepository planningGroupRepository,
            IJobPositionRepository jobPositionRepository,
            IPriorityRepository priorityRepository,
            ICauseRepository causeRepository,
            IActivityRepository activityRepository,
            IFaultRepository faultRepository,
            ISymptomFaultRepository symptomFaultRepository)
        {
            _notificationClassRepository = notificationClassRepository;
            _planningGroupRepository = planningGroupRepository;
            _jobPositionRepository = jobPositionRepository;
            _priorityRepository = priorityRepository;
            _causeRepository = causeRepository;
            _activityRepository = activityRepository;
            _faultRepository = faultRepository;
            _symptomFaultRepository = symptomFaultRepository;
        }

        [HttpGet("FindId/{idMasterTable}")]
        public async Task<IActionResult> FindId(int idMasterTable)
        {
            switch ((MasterTableType)idMasterTable)
            {
                case MasterTableType.NotificationCLass:
                    return Ok(await _notificationClassRepository.FindAll());
                case MasterTableType.PlanificationGroup:
                    return Ok(await _planningGroupRepository.FindAll());
                case MasterTableType.JobPosition:
                    return Ok(await _jobPositionRepository.FindAll());
                case MasterTableType.Priority:
                    return Ok(await _priorityRepository.FindAll());
                case MasterTableType.Fault:
                    return Ok(await _faultRepository.FindAll());
                case MasterTableType.Cause:
                    return Ok(await _causeRepository.FindAll());
                case MasterTableType.Activity:
                    return Ok(await _activityRepository.FindAll());
                case MasterTableType.SymptomFault:
                    return Ok(await _symptomFaultRepository.FindAll());
                default:
                    break;
            }
            return BadRequest();
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
        SymptomFault
    }
}
