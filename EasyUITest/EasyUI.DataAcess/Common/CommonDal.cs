using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyUI.Framework.CommonDataDao;
using  EasyUI.Model.Common;

namespace EasyUI.DataAcess.Common
{
    public class CommonDal:BaseDataDao
    {
        public IList<Student> GetStudentList(Student model)
        {
            return ExecuteQueryForList<Student>("GetStudents", model);
        }
        public object InsertStudents(Student model)
        {
            return ExecuteInsert("InsertStudents", model);
        }

        //man
        public IList<Man> GetManList(Man model)
        {
            return ExecuteQueryForList<Man>("GetMen", model);
        }
        public object InsertMan(Man model)
        {
            return ExecuteInsert("InsertMan", model);
        }
        public object EditMan(Man model)
        {
            return ExecuteUpdate("EditMan", model);
        }
    }
}
