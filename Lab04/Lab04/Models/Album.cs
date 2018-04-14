using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04.Models
{
    public class Album<T>
    {
       // public string nombre { get; set; }
        public List<T> faltantes = new List<T>();
        public List<T> coleccionadas = new List<T>();
        public List<T> cambios = new List<T>();
    }
}