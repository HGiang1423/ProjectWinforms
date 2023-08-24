using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherBEL
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Gioitinh { get; set; }
        public string Malop { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public AreaBEL Area { get; set; }
        public string AreaName
        {
            get { return Area.Name; }
        }
    }
}
