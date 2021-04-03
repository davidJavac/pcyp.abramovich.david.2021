using System;
using System.IO;

namespace Clase3.Ejercicio4.Netflix.util
{
    public class ApplicationConstants
    {
        public static class Resources { 

            public static String RATING_TXT_FOLDER = $@"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\\resources\\rating-txt";
            
        }

        public static class Status
        {
            public static String SUCCESS = "success";
            public static String ERROR = "error";
        }
    }
}
