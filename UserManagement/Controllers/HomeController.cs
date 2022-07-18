using Domains.Entities;
using Domains.Repositories;
using Domains.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> SignInManager;
        private readonly UserManager<IdentityUser> UserManager;
        private readonly IAgreementRepository agreementRepository;
        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> UserManager,
            SignInManager<IdentityUser> SignInManager, IAgreementRepository agreementRepository)
        {
            _logger = logger;
            this.SignInManager = SignInManager;
            this.UserManager = UserManager;
            this.agreementRepository = agreementRepository;
        }

        public IActionResult Index()
        {
            var pgList = agreementRepository.GetProductGroup();
            var listToClient = pgList.Select(p => new
            {
                p.GroupDescription,
                p.Id

            }).ToList();
            ViewBag.ProjectGroup = listToClient.Select(i => new SelectListItem
            {
                Text = i.GroupDescription,
                Value = i.Id.ToString()
            });

            var pList = agreementRepository.GetProduct();
            var listToProd = pList.Select(p => new
            {
                p.ProductDescription,
                p.Id
            }).ToList();
            ViewBag.Project = listToProd.Select(i => new SelectListItem
            {
                Text = i.ProductDescription,
                Value = i.Id.ToString()
            });

            var uList = UserManager.Users.ToList();
            var listOfUsers = uList.Select(p => new
            {
                p.Email,
                p.Id
            }).ToList();
            ViewBag.UserList = listOfUsers.Select(i => new SelectListItem
            {
                Text = i.Email,
                Value = i.Id.ToString()
            });

            return View();
        }

        public IActionResult GetAgreements()
        {
            try
            {
                //Creating instance of DatabaseContext class  

                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();


                //Paging Size (10,20,50,100)    
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data    
                var customerData = agreementRepository.GetAgreements();

                //Sorting    
                //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                //{
                //    customerData = customerData.ToList().OrderBy(sortColumn + " " + sortColumnDir);
                //}
                ////Search    
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.UserId == searchValue).ToList();
                }
                //--------------------------------------

                //total number of rows count     
                recordsTotal = customerData.Count();
                //Paging     
                var data1 = customerData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data    
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data1 });

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public IActionResult Insert()
        {
            return View("AddEditAgreement");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var agr = await agreementRepository.GetById(id);
            AgreementViewModel obj = new AgreementViewModel();
            obj.Id = agr.Id;
            obj.UserId = agr.UserId;
            obj.ProductGroupId = agr.ProductGroupId;
            obj.ProductId = agr.ProductId;
            obj.EffectiveDate = agr.EffectiveDate;
            obj.ExpirationDate = agr.ExpirationDate;
            obj.ProductPrice = agr.ProductPrice;
            obj.NewPrice = agr.NewPrice;
            obj.WhenEntered = DateTime.UtcNow;
            obj.IsActive = agr.IsActive;
            return Ok(obj);
        }

        public async Task<IActionResult> AddEditAgreement(AgreementViewModel model)
        {
            if (model.Id == 0)
            {
                //add
                Agreement obj = new Agreement();
                obj.UserId = model.UserId;
                obj.ProductGroupId = model.ProductGroupId;
                obj.ProductId = model.ProductId;
                obj.EffectiveDate = model.EffectiveDate;
                obj.ExpirationDate = model.ExpirationDate;
                obj.ProductPrice = model.ProductPrice;
                obj.NewPrice = model.NewPrice;
                obj.WhenEntered = DateTime.UtcNow;
                obj.IsActive = true;
                await agreementRepository.Insert(obj);
            }
            else
            {
                //Edit
                Agreement obj = new Agreement();
                obj.UserId = model.UserId;
                obj.ProductGroupId = model.ProductGroupId;
                obj.ProductId = model.ProductId;
                obj.EffectiveDate = model.EffectiveDate;
                obj.ExpirationDate = model.ExpirationDate;
                obj.ProductPrice = model.ProductPrice;
                obj.NewPrice = model.NewPrice;
                obj.IsActive = model.IsActive;
                await agreementRepository.Update(obj);
            }

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteAgreement(int Id)
        {
            var agreement = await agreementRepository.GetById(Id);
            if (Id == 0)
                return Json(data: "Not Deleted");

            await agreementRepository.Remove(agreement);
            return Json(data: "Deleted");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
