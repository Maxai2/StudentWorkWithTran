﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace StudentWorkWithTran
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_Faculty { get; set; }
        //-------------------------------------------------------------------------
        public string Info { get { return GroupName(); } }
        //-------------------------------------------------------------------------
        public string GroupName() => String.Format($"{Name}");
    }
}
