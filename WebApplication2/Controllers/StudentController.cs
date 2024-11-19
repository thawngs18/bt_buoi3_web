using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public static List<Student> StudentList = new List<Student>(); // Danh sách lưu tạm

        [HttpPost]
        public IActionResult ShowKQ(Student student)
        {
            // Lưu sinh viên vào danh sách
            StudentList.Add(student);

            // Đếm số sinh viên cùng chuyên ngành
            int count = StudentList.Count(s => s.ChuyenNganh == student.ChuyenNganh);

            // Truyền dữ liệu sang View
            ViewBag.MSSV = student.MSSV;
            ViewBag.HoTen = student.HoTen;
            ViewBag.ChuyenNganh = student.ChuyenNganh;
            ViewBag.Count = count;

            return View();
        }


    }
}
