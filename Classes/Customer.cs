﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field
        //public string FirstName;

        //Property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


        //Encapsulation
        /* 
         * private string _firstName;
            public string FirstName
           {
            get  {  return "Mr."+_firstName;  }
            set { _firstName = value;}
            }   
        */

    }
}
