using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab04.Models;

namespace Lab04.DBContext
{
    public class DefaultConnection
    {
        private static volatile DefaultConnection Instance;
        private static object syncRoot = new Object();
        public Dictionary<string, Album<int>> Album = new Dictionary<string,Album<int>>();
        public Dictionary<Calcomania, bool> repetidaFaltante = new Dictionary<Calcomania, bool>();
        public List<Calcomania> Faltantes = new List<Calcomania>();

        public int IDActual { get; set; }

        private DefaultConnection()
        {
            IDActual = 0;
        }

        public static DefaultConnection getInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (syncRoot)
                    {
                        if (Instance == null)
                        {
                            Instance = new DefaultConnection();
                        }
                    }
                }
                return Instance;
            }
        }
    }
}