using System;

namespace Clase1Ejercicio2Vial.core.entity
{
    public class VialDto
    {
        private int n_sheet;
        private String objectType;
        private int idSection;
        private String pathType;
        private long lenght;

        public VialDto(int n_sheet, String objectType, int idSection, String pathType, long lenght) {
            this.n_sheet = n_sheet;
            this.objectType = objectType;
            this.idSection = idSection;
            this.pathType = pathType;
            this.lenght = lenght;
        }

        public int N_sheet { get => n_sheet; set => n_sheet = value; }
        public string ObjectType { get => objectType; set => objectType = value; }
        public int IdSection { get => idSection; set => idSection = value; }
        public string PathType { get => pathType; set => pathType = value; }
        public long Lenght { get => lenght; set => lenght = value; }
    }
}
