using BrandBucket_DataAccess.Repository.IRepository;
using BrandBucket_Models.ViewModels;
using BrandBucket_Utility;
using BrandBucket_Utility.BrainTree;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrandBucket.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderHeaderRepository _orderHRepo;
        private readonly IOrderDetailRepository _orderDRepo;
        private readonly IBrainTreeGate _brain;
        public OrderController(
            IOrderHeaderRepository orderHRepo, IOrderDetailRepository orderDRepo, IBrainTreeGate brain)
        {
            _orderDRepo = orderDRepo;
            _orderHRepo = orderHRepo;
            _brain = brain;
        }
        public IActionResult Index()
        {
            OrderListVM orderListVM = new OrderListVM()
            {
                OrderHList = _orderHRepo.GetAll(),
                StatusList = WC.listStatus.ToList().Select(i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Text = i,
                    Value = i
                })
            };
            return View(orderListVM);
        }
    }
}
