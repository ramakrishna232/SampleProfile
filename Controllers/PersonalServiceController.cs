using Microsoft.AspNetCore.Mvc;
namespace PMS_API
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class PersonalServiceController : Controller
    {
        private IPersonalService _personalService;
        private ILogger _logger;
        public PersonalServiceController(IPersonalService personalService, ILogger<PersonalServiceController> logger)
        {
            _personalService = personalService;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult GetallPersonalDetails()
        {
            try
            {

                return Ok(_personalService.GetallPersonalDetails());
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"UserController :GetAllPersonalDetails()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }


        }
        [HttpGet]
        public IActionResult GetPersonalDetailsById(int id)
        {
            try{
                
                return Ok(_personalService.GetPersonalDetailsById(id));
            }
            catch(Exception exception){
                _logger.LogInformation($"PersonalServiceController :GetPersonalDetailsById()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
               return BadRequest(exception.Message);
            }
        }

        [HttpPost]
        public IActionResult AddPersonalDetail(PersonalDetails personalDetails)
        {
            if (User == null)
            {
                _logger.LogError("PersonalServiceController:AddPersonalDetail():User tries to enter null values");
                return BadRequest("PersonalDetails not be null");
            }
            try
            {
                return _personalService.AddPersonalDetail(personalDetails) ? Ok("PersonalDetails added") : Problem("Some internal Error occured");
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceControllerController :AddPersonalDetail()-{exception.Message}{exception.StackTrace}");

                return BadRequest(exception.Message);
            }



        }
        [HttpDelete]
        public IActionResult RemovePersonalDetail(int PersonalDetails_Id)
        {
            if (PersonalDetails_Id == 0)
                return BadRequest("PersonalDetails_ Id can't be null");


            try
            {
                return _personalService.RemovePersonalDetail(PersonalDetails_Id) ? Ok("PersonalDetails_ Removed Successfully") : Problem("Sorry internal error occured");
            }

            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalDetail_ Service : RemovePersonalDetail_ throwed an exception : {exception}");
                return BadRequest("Sorry some internal error occured");
            }

        }
        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            if (education == null)
            {
                _logger.LogError("PersonalServiceController:AddEducation():user tries to enter null values");
                return BadRequest("Education details not be null");
            }
            try
            {
                return _personalService.AddEducation(education) ? Ok("Education details added") : Problem("Some internal Error occured");
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceControllerController :AddEducation()-{exception.Message}{exception.StackTrace}");

                return BadRequest(exception.Message);
            }


        }
        [HttpGet]
        public IActionResult GetallEducationDetails()
        {
            try
            {

                return Ok(_personalService.GetallEducationDetails());
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceController :GetallEducationDetails()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }


        }
        [HttpGet]
        public IActionResult GetEducationDetailsById(int Educationid)
        {
            try{
                
                return Ok(_personalService.GetEducationDetailsById(Educationid));
            }
            catch(Exception exception){
                _logger.LogInformation($"PersonalServiceController :GetEducationById()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
               return BadRequest(exception.Message);
            }
        }

        [HttpDelete]
        public IActionResult RemoveEducation(int EducationId)
        {
            if (EducationId == 0)
                return BadRequest("Education_ Id can't be null");


            try
            {
                return _personalService.RemoveEducation(EducationId) ? Ok("Education_ Removed Successfully") : Problem("Sorry internal error occured");
            }

            catch (Exception exception)
            {
                _logger.LogInformation($"Education_ Service : RemoveEducation_ throwed an exception : {exception}");
                return BadRequest("Sorry some internal error occured");
            }

        }
        [HttpGet]
        public IActionResult GetallProjectDetails()
        {
            try
            {

                return Ok(_personalService.GetallProjectDetails());
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceController :GetallProjectDetails()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }


        }
        [HttpGet]
        public IActionResult GetProjectDetailsById(int Projectid)
        {
            try{
                
                return Ok(_personalService.GetProjectDetailsById(Projectid));
            }
            catch(Exception exception){
                _logger.LogInformation($"PersonalServiceController :GetallProjectDetails()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
               return BadRequest(exception.Message);
            }
        }
        [HttpPost]
        public IActionResult AddProjects(Projects projects)
        {
            if (projects == null)
            {
                _logger.LogError("PersonalServiceController:AddProjects():user tries to enter null values");
                return BadRequest("Education details not be null");
            }
            try
            {
                return _personalService.AddProjects(projects) ? Ok("project details added") : Problem("Some internal Error occured");
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceControllerController :AddProjects()-{exception.Message}{exception.StackTrace}");

                return BadRequest(exception.Message);
            }

        }
        [HttpDelete]
        public IActionResult RemoveProjects(int Projects_Id)
        {
            if (Projects_Id == 0)
                return BadRequest("Projects_ Id can't be null");


            try
            {
                return _personalService.RemoveProjects(Projects_Id) ? Ok("Projects_ Removed Successfully") : Problem("Sorry internal error occured");
            }

            catch (Exception exception)
            {
                _logger.LogInformation($"Projects_ Service : RemoveProjects_ throwed an exception : {exception}");
                return BadRequest("Sorry some internal error occured");
            }

        }
        [HttpGet]
        public IActionResult GetallSkillDetails()
        {
            try
            {

                return Ok(_personalService.GetallSkillDetails());
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceController : GetallSkillDetails()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }


        }
        [HttpGet]
        public IActionResult GetSkillDetailsById(int Skillid,int Technologyid)
        {
            try{
                
                return Ok(_personalService.GetSkillDetailsById(Skillid,Technologyid));
            }
            catch(Exception exception){
                _logger.LogInformation($"PersonalServiceController : GetallSkillDetails()- exception occured while fetching record{exception.Message}{exception.StackTrace}");
               return BadRequest(exception.Message);
            }
        }
        [HttpPost]
        public IActionResult AddSkills(Skills skill)
        {
            if (skill == null)
            {
                _logger.LogError("PersonalServiceController:AddSkills():user tries to enter null values");
                return BadRequest("Education details not be null");
            }
            try
            {
                return _personalService.AddSkills(skill) ? Ok("Skill details added") : Problem("Some internal Error occured");
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceControllerController :AddSkills()-{exception.Message}{exception.StackTrace}");

                return BadRequest(exception.Message);
            }

        }
        [HttpDelete]
        public IActionResult RemoveSkills(int Skill_Id)
        {
            if (Skill_Id == 0)
                return BadRequest("Skill_ Id can't be null");


            try
            {
                return _personalService.RemoveSkills(Skill_Id) ? Ok("Skills_ Removed Successfully") : Problem("Sorry internal error occured");
            }

            catch (Exception exception)
            {
                _logger.LogInformation($"Skills_ Service : RemoveProjects_ throwed an exception : {exception}");
                return BadRequest("Sorry some internal error occured");
            }

        }
        [HttpPost]
        public IActionResult AddBreakDuration(BreakDuration duration,int userID)
        {
            if (duration == null)
            {
                _logger.LogError("PersonalServiceController:AddBreakDuration():user tries to enter null values");
                return BadRequest("BreakDuration details not be null");
            }
            try
            {
                return _personalService.AddBreakDuration(duration,userID) ? Ok("BreakDuration details added") : Problem("Some internal Error occured");
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceControllerController :AddBreakDuration()-{exception.Message}{exception.StackTrace}");

                return BadRequest(exception.Message);
            }

        }
        [HttpDelete]
        public IActionResult RemoveBreakDuration(int BreakDuration_Id)
        {
            if (BreakDuration_Id == 0)
                return BadRequest("BreakDuration_ Id can't be null");


            try
            {
                return _personalService.RemoveBreakDuration(BreakDuration_Id) ? Ok("BreakDuration_ Removed Successfully") : Problem("Sorry internal error occured");
            }

            catch (Exception exception)
            {
                _logger.LogInformation($"BreakDuration_ Service : RemoveBreakDuration_ throwed an exception : {exception}");
                return BadRequest("Sorry some internal error occured");
            }

        }
        [HttpPost]
        public IActionResult AddLanguage(Language language)
        {
            if (language == null)
            {
                _logger.LogError("PersonalServiceController:AddLanguage():user tries to enter null values");
                return BadRequest("Language details not be null");
            }
            try
            {
                return _personalService.AddLanguage(language) ? Ok("Language details added") : Problem("Some internal Error occured");
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceControllerController :AddSkills()-{exception.Message}{exception.StackTrace}");

                return BadRequest(exception.Message);
            }

        }
        [HttpDelete]
        public IActionResult RemoveLanguage(int Language_Id)
        {
            if (Language_Id == 0)
                return BadRequest("Language_ Id can't be null");


            try
            {
                return _personalService.RemoveLanguage(Language_Id) ? Ok("Language_ Removed Successfully") : Problem("Sorry internal error occured");
            }

            catch (Exception exception)
            {
                _logger.LogInformation($"SocialMedia_ Service : RemoveSocialMedia_ throwed an exception : {exception}");
                return BadRequest("Sorry some internal error occured");
            }
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia media)
        {
            if (media == null)
            {
                _logger.LogError("PersonalServiceController:AddSocialMedia():user tries to enter null values");
                return BadRequest("social media details not be null");
            }
            try
            {
                return _personalService.AddSocialMedia(media) ? Ok("Social media details added") : Problem("Some internal Error occured");
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceControllerController :AddSocialMedia()-{exception.Message}{exception.StackTrace}");

                return BadRequest(exception.Message);
            }

        }
        [HttpDelete]
        public IActionResult RemoveSocialMedia(int SocialMedia_Id)
        {
            if (SocialMedia_Id == 0)
                return BadRequest("SocialMedia_ Id can't be null");


            try
            {
                return _personalService.RemoveSocialMedia(SocialMedia_Id) ? Ok("SocialMedia_ Removed Successfully") : Problem("Sorry internal error occured");
            }

            catch (Exception exception)
            {
                _logger.LogInformation($"SocialMedia_ Service : RemoveSocialMedia_ throwed an exception : {exception}");
                return BadRequest("Sorry some internal error occured");
            }

        }
        [HttpPost]
        public IActionResult AddAchievement(Achievements achievement)
        {
            if(achievement==null)
            {
                _logger.LogError("PersonalServiceController:AddAchievement():user tries to enter null values");
                return BadRequest("achievement details not be null");
            }
            try
            {
                return _personalService.AddAchievements(achievement) ? Ok("Achievements details added") : Problem("Some internal Error occured");
            }
            catch (Exception exception)
            {
                _logger.LogInformation($"PersonalServiceControllerController :AddAchievement()-{exception.Message}{exception.StackTrace}");

                return BadRequest(exception.Message);
            }
        }
        [HttpDelete]
        public IActionResult RemoveAchievement(int achievementId)
        {
            if (achievementId <= 0)
                return BadRequest($"achievement id can't be zero or less than 0 achievementId is supplied as {achievementId}");


            try
            {
                return _personalService.RemoveAchievement(achievementId) ? Ok("SocialMedia_ Removed Successfully") : Problem("Sorry internal error occured");
            }

            catch (Exception exception)
            {
                _logger.LogInformation($" PersonalServiceControllerController : RemoveAchievement() : {exception.Message}{exception.StackTrace}");
                return BadRequest(exception.Message);
            }
        }
    }
}