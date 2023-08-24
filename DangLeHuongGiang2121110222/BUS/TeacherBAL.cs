using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TeacherBAL
    {
        TeacherDAL dal = new TeacherDAL();
        public List<TeacherBEL> ReadTeacher()
        {
            List<TeacherBEL> lstCus = dal.ReadTeacher();
            return lstCus;
        }
        public void NewTeacher(TeacherBEL cus)
        {
            dal.NewTeacher(cus);
        }
        public void DeleteTeacher(TeacherBEL cus)
        {
            dal.DeleteTeacher(cus);
        }
        public void EditTeacher(TeacherBEL cus)
        {
            dal.EditTeacher(cus);
        }
    }
}
