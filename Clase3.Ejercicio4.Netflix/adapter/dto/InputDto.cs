using Clase3.Ejercicio4.Netflix.usecase.validation;
using Clase3.Ejercicio4.Netflix.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Ejercicio4.Netflix.adapter.dto
{
    public class InputDto : ValidationInvoker
    {
        private string fileName;

        public InputDto(String fileName) {
            this.FileName = fileName;
        }
        
        public string FileName { get => fileName; set => fileName = value; }
        
        public void callValidations() {
            try
            {
                this.invokeValidations();
            }
            catch (Exception e) {
                throw e;
            }
        }

        protected override void invokeValidations() {
            
            ModuleConfig.getValidateInput().ForEach(val => val.execute(this));
            
        }

    }
}
