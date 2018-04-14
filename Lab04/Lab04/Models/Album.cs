using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04.Models
{
    public class Album
    {
       // public string nombre { get; set; }
        public List<int> faltantes = new List<int>();
        public List<int> coleccionadas = new List<int>();
        public List<int> cambios = new List<int>();
    }
}