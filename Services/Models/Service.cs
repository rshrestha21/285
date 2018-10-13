using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class Service
    {
        public int ID { get; set; }

        public String Name { get; set; }

        public String Desription {get; set;}

        public DateTime Startdate { get; set; }

        public DateTime Enddate { get; set; }


        public virtual Servicetype servicetype { get; set; }


    }

}