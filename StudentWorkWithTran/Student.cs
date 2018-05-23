using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkWithTran
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id_Group { get; set; }
        public int Term { get; set; }
        //-------------------------------------------------------------------------
        public string Info { get { return StudFirstLastName(); } }
        //-------------------------------------------------------------------------
        public string StudFirstLastName() => String.Format($"{FirstName} {LastName}");
    }
}
