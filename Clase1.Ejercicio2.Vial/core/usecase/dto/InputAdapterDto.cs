using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1Ejercicio2Vial.usecase.dto
{
    public class InputAdapterDto
    {
        private String path;

        public InputAdapterDto() {
            
        }

        public InputAdapterDto(String path) {
            this.Path = path;
        }

        public string Path { get => path; set => path = value; }
    }
}
