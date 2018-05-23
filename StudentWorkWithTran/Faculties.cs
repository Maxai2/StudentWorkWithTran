using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkWithTran
{
    public class Faculties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //-------------------------------------------------------------------------
        public string Info { get { return FacultiesName(); } }
        //-------------------------------------------------------------------------
        public string FacultiesName() => String.Format($"{Name}");
    }
}
