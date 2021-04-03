using Clase3.Ejercicio3.WordCount.usecase.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.WordsCount.interface_adapter.dto
{
    class InputDto : Input
    {
        private String text;
        public override object getValue()
        {
            return this.text;
        }

        public override void setValue(object value)
        {
            this.text = (String)value;
        }
    }
}
