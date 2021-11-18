using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using System.Data;
using DEMOBT.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DEMOBT.Controllers
{
    public class UploadExcelController : Controller
    {
        LTQLDbContext db = new LTQLDbContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(HttpPostedFileBase file)
        {
            DataTable dt = CopyDataFromExcelFile(file);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    var kh = new KhachHang();
            //    kh.MaKhachHang = dt.Rows[i][0].ToString();
            //    kh.TenKhachHang = dt.Rows[i][1].ToString();
            //    kh.SoDienThoai = dt.Rows[i][2].ToString();
            //    db.KhachHangs.Add(kh);
            //}
            //db.SaveChanges();
            OverwriteFastData(dt);
            return RedirectToAction("Index", "KhachHang");
        }

        ReadDataFromExcelFile excelPro = new ReadDataFromExcelFile();

        public DataTable CopyDataFromExcelFile(HttpPostedFileBase file)
        {
            string fileExtention = file.FileName.Substring(file.FileName.IndexOf("."));
            string _FileName = "DS_KH" + fileExtention;
            string _path = Path.Combine(Server.MapPath("~/Uploads/Excels"), _FileName);
            file.SaveAs(_path);
            DataTable dt = excelPro.ReadDataFromExcelFiles(_path, true);
            return dt;
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LTQLDbContext"].ConnectionString);
        private void OverwriteFastData(DataTable dt)
        {
            SqlBulkCopy bulkCopy = new SqlBulkCopy(con);
            bulkCopy.DestinationTableName = "KhachHangs";
            bulkCopy.ColumnMappings.Add(0, "MaKhachHang");
            bulkCopy.ColumnMappings.Add(1, "TenKhachHang");
            bulkCopy.ColumnMappings.Add(2, "SoDienThoai");

            con.Open();
            bulkCopy.WriteToServer(dt);
            con.Close();
        }  
    }

}



