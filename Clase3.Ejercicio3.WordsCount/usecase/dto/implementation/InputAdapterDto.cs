using Clase3.Ejercicio3.WordCount.usecase.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.WordsCount.usecase.dto.implementation
{
    class InputAdapterDto : Input
    {
        private List<String> value;
        public override object getValue()
        {
            return this.value;
        }
        public override void setValue(object value)
        {
            this.value = (List<String>)value;
        }
    }
}
