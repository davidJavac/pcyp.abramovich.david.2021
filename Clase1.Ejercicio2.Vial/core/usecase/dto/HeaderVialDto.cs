using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1.Ejercicio2.Vial.core.usecase.dto
{
    class HeaderVialDto
    {
        private String n_sheet = "n_sheet";
        private String object_type = "object_type";
        private String id_section = "id_section";
        private String path_type = "path_type";
        private String lenght = "lenght";

        public string N_sheet { get => n_sheet; set => n_sheet = value; }
        public string Object_type { get => object_type; set => object_type = value; }
        public string Id_section { get => id_section; set => id_section = value; }
        public string Path_type { get => path_type; set => path_type = value; }
        public string Lenght { get => lenght; set => lenght = value; }
    }
}
