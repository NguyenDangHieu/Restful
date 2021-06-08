using Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restful.Controllers
{
    public class TaiKhoanController : ApiController
    {
        // Get Api/Taikhoan/Danhsach
        [HttpGet]
        public List<TaiKhoan> DanhSach() => new DataContext().TaiKhoans.ToList();
    }
}
