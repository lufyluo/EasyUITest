using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyUI.Business.Common;
using EasyUI.Model.Common;
using Newtonsoft.Json;

namespace EasyUITest.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EasyUi()
        {
            return View();
        }
        public ActionResult Man()
        {
            return View();
        }
        //man
        public ActionResult LoadManData()
        {
            var manBll = new CommonBll();
            var manList = manBll.GetManList(new Man());
            return Json(manList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddMan(Man model)
        {
            var manBll = new CommonBll();
            var manList = manBll.InsertMan(model);
            return Json(manList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateMan(Man model)
        {
            var manBll = new CommonBll();
            var manList = manBll.EditMan(model);
            return Json(manList, JsonRequestBehavior.AllowGet);
        }

        //student
        public ActionResult LoadData()
        {
            var stuBll = new CommonBll();
            var stuList = stuBll.GetStudentList(new Student());
            return Json(stuList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult addStudent(Student strParams)
        {
            var stuBll = new CommonBll();
            var obj = stuBll.InsertStudent(strParams);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult updateStudent(int id)
        {
            Console.WriteLine(id);
            return null;
        }
        public ActionResult delStudent(int id)
        {
            return null;
        }
    }
}