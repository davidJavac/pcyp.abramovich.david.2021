using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lists.usecase.dto.implementation
{
    class InputDto
    {
        private String[] colors;
        private String[] removecolors;
        public string[] Colors { get => colors; set => colors = value; }
        public string[] Removecolors { get => removecolors; set => removecolors = value; }
    }
}
