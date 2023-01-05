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
        public MasterTableController(INotificationClassRepository notificationClassRepository,
            IPlanningGroupRepository planningGroupRepository,
            IJobPositionRepository jobPositionRepository,
            IPriorityRepository priorityRepository,
            ICauseRepository causeRepository,
            IActivityRepository activityRepository)
        {
            _notificationClassRepository = notificationClassRepository;
            _planningGroupRepository = planningGroupRepository;
            _jobPositionRepository = jobPositionRepository;
            _priorityRepository = priorityRepository;
            _causeRepository = causeRepository;
            _activityRepository = activityRepository;
        }

        [HttpGet("NotificationClassFindAll")]
        public async Task<IActionResult> NotificationClassFindAll()
        {
            var response  = await _notificationClassRepository.FindAll();
            return Ok(response);
        }

        [HttpGet("PlanningGroupFindAll")]
        public async Task<IActionResult> PlanningGroupFindAll()
        {
            var response = await _planningGroupRepository.FindAll();
            return Ok(response);
        }

        [HttpGet("JobPositionFindAll")]
        public async Task<IActionResult> JobPositionFindAll()
        {
            var response = await _jobPositionRepository.FindAll();
            return Ok(response);
        }

        [HttpGet("PriorityFindAll")]
        public async Task<IActionResult> PriorityFindAll()
        {
            var response = await _priorityRepository.FindAll();
            return Ok(response);
        }

        [HttpGet("CauseFindAll")]
        public async Task<IActionResult> CauseFindAll()
        {
            var response = await _causeRepository.FindAll();
            return Ok(response);
        }

        [HttpGet("ActivityFindAll")]
        public async Task<IActionResult> ActivityFindAll()
        {
            var response = await _activityRepository.FindAll();
            return Ok(response);
        }
    }
}
