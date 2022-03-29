using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FrentHw
{
     public class Order
    {
        public int Id { get; set; }
        public DateTime DatеBegin {get; set;}
        //public DateTime DatеExpiration { get; set;}
        public decimal Summ { get; set; }
        public User Customer { get; set; }
        [MaxLength(50)]
        public String Description { get; set; }

        /* public string Description 
         { get 
            { return Description; }
           set 
            { Description = Console.ReadLine(); }
         }
        */



    }
}
