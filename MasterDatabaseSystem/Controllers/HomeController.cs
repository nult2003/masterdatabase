using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MasterDatabaseSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Trang này lưu trữ master database được tập hợp từ nhiều nguồn. "+
                "Dữ liệu gồm những danh mục được xử dụng phổ biến trong các đơn vị hành chánh, v.v..";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Địa chỉ văn phòng";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
