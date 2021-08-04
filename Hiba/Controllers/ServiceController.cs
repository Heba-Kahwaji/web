using Hiba.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiba.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ServiceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Coaching()
        {
            var data = _context.Pages.SingleOrDefault(p => p.Name == "Coaching");
            return View("~/Views/Service/Coaching/Index.cshtml",data);
        }
        public IActionResult NutritionAndHealthConsultations()
        {
            return View("~/Views/Service/NutritionAndHealthConsultations/Index.cshtml");
        }
        public IActionResult FinancialConsults()
        {
            var data = _context.Pages.SingleOrDefault(p => p.Name == "Financial Consults");
            return View("~/Views/Service/EconomicConsultations/FinancialConsults.cshtml", data);
        }
        public IActionResult EconomicConsults()
        {
            var data = _context.Pages.SingleOrDefault(p => p.Name == "Economic Consults");
            return View("~/Views/Service/EconomicConsultations/EconomicConsults.cshtml",data);
        }
        public IActionResult ManagementConsults()
        {
            var data = _context.Pages.SingleOrDefault(p => p.Name == "Management Consults");
            return View("~/Views/Service/EconomicConsultations/ManagementConsults.cshtml", data);
        }
        public IActionResult EconomicConsultations()
        {
            return View("~/Views/Service/EconomicConsultations/Index.cshtml");
        }
        public IActionResult FamilyConsultations()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/FamilyConsultations/Index.cshtml");
        }
        public IActionResult RaisingChildrenConsultations()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/FamilyConsultations/RaisingChildrenConsultations.cshtml");
        }

        public IActionResult MaritalConsultations()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/FamilyConsultations/MaritalConsultations.cshtml");
        }
        public IActionResult AdolescentCounseling()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/FamilyConsultations/AdolescentCounseling.cshtml");
        }

        public IActionResult PsychologicalCounseling()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/PsychologicalCounseling/Index.cshtml");
        }

        public IActionResult SocialAndImprovementConsultations()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/Index.cshtml");
        }

        public IActionResult SelfImprovementConsultations()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/SelfImprovementConsultations/Index.cshtml");
        }

        public IActionResult OnlineCourses()
        {
            var data = _context.TrainingProgram.Where(t => t.TrainingType == Common.Enums.TrainingType.OnlineCourses).ToList();
            return View("~/Views/Service/Training/OnlineCourses.cshtml", data);
        }
        public IActionResult CurrentTrainingCourses()
        {
            var data = _context.TrainingProgram.Where(t => t.TrainingType == Common.Enums.TrainingType.CurrentCourses).ToList();
            return View("~/Views/Service/Training/CurrentTrainingCourses.cshtml");
        }
        public IActionResult TrainingPrograms()
        {
            var data = _context.TrainingProgram.Where(t => t.TrainingType == Common.Enums.TrainingType.TrainingPrograms).ToList();
            return View("~/Views/Service/Training/TrainingPrograms.cshtml", data);
        }

        public IActionResult Course(int id)
        {
            return View("~/Views/Service/Training/Course.cshtml");
        }
        public IActionResult Training()
        {
            return View("~/Views/Service/Training/Index.cshtml");
        }


        public IActionResult YouthProblems()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/SelfImprovementConsultations/YouthProblems.cshtml");
        }

        public IActionResult CareerProblem()
        {
            return View("~/Views/Service/SocialAndImprovementConsultations/SelfImprovementConsultations/CareerProblem.cshtml");
        }

        public IActionResult LecturesWorkshops()
        {
            var data = _context.LectureWorkshops.ToList();
            return View("~/Views/Service/LecturesWorkshops/Index.cshtml",data);
        }

    }
}
