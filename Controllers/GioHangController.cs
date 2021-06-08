using Restful.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restful.Controllers
{
    public class GioHangController : ApiController
    {
        // Get Api/GioHang/Danhsach
        [HttpGet]
        public HttpResponseMessage DanhSach() {
            //List<TaiKhoan> lstTK = new DataContext().TaiKhoans.ToList();
            //List<SanPham> lstSP = new DataContext().SanPhams.ToList();
            DataContext context = new DataContext();
            List<GioHang> lst = new List<GioHang>();
            foreach (var item in context.GioHangs)
            {
                TaiKhoan tk = context.TaiKhoans.Find(item.Id_TaiKhoan);
                item.TaiKhoan = tk;
                SanPham sp = context.SanPhams.Find(item.Id_SanPham);
                item.SanPham = sp;
                lst.Add(item);
            }

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lst);
            return response;

        }
       

      
        // POST /giohang/tao-gio-hang

        // PUT /giohang/cap-nhat

        // DELETe /giohang/xoa

    }
}
