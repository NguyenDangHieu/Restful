using Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restful.Controllers
{
    public class SanPhamController : ApiController
    {
        // Get Api/Sanpham/Danhsach
        [HttpGet]
        public List<SanPham> DanhSach() => new DataContext().SanPhams.ToList();
    }
}
