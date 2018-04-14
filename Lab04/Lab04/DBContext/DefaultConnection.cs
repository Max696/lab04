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
        public Dictionary<string, Album> Album = new Dictionary<string,Album>();
        public Dictionary<Calcomania, bool> repetidaFaltante = new Dictionary<Calcomania, bool>();

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