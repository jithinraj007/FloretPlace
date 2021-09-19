using BrandBucket_DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrandBucket.Controllers
{

    public class InquiryController : Controller
    {
        private readonly IInquiryHeaderRepository _inqHRepo;
        private readonly IInquiryDetailRepository _inqDRepo;

        public InquiryController(IInquiryDetailRepository inqDRepo, IInquiryHeaderRepository inqHRepo)
       
        {
            _inqDRepo = inqDRepo;
            _inqHRepo = _inqHRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
