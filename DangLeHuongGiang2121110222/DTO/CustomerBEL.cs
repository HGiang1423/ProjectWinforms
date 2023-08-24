using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerBEL
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Gioitinh { get; set; }
        public string Malop { get; set; }
        public AreaBEL Area { get; set; }
        public string AreaName
        {
            get { return Area.Name; }
        }
    }
}
