using System;
using System.IO;

namespace Clase1Ejercicio2Vial.util
{
    public class ApplicationConstants
    {
        public static class Resources { 

            public static String VIAL_CSV_FOLDER = $@"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\\resources\\vial-csv";
            
        }

        public static class Status
        {
            public static String SUCCESS = "success";
            public static String ERROR = "error";
        }

        public static class DtoKey {

            public static String HEADER = "header";
        }
    }
}
