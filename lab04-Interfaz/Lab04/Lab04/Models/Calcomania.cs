using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab04.Models
{
    public class Calcomania
    {
        
        public string nombre { get; set; }
       [Display(Name= "Encontrado")]
        public bool existe { get; set; }
         [Display(Name = "Numero")]
        public int id { get; set; }
       
    }
}