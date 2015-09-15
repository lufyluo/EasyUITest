using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyUI.DataAcess.Common;
using EasyUI.Model.Common;

namespace EasyUI.Business.Common
{
    public class CommonBll
    {
        private readonly CommonDal dal;

        public CommonBll()
        {
            dal = new CommonDal();
        }
        //student
        public IList<Student> GetStudentList(Student model)
        {
            return dal.GetStudentList(model);
        }

        public object InsertStudent(Student model)
        {
            return dal.InsertStudents(model);
        }
        //man
        public IList<Man> GetManList(Man model)
        {
            return dal.GetManList(model);
        }

        public object InsertMan(Man model)
        {
            return dal.InsertMan(model);
        }

        public object EditMan(Man model)
        {
            return dal.EditMan(model);
        }
    }
}
