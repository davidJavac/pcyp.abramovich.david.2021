using Clase1Ejercicio2Vial.usecase.validation;
using Clase1Ejercicio2Vial.config;
using System;
using System.Collections.Generic;
using System.Text;
using Clase1.Ejercicio2.Vial.core.usecase.dto;

namespace Clase1Ejercicio2Vial.adapter.dto
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
                normalize();
                this.invokeValidations();
            }
            catch (Exception e) {
                throw e;
            }
        }

        private void normalize() {
            FileName = FileName.ToLower();
     
        }

        protected override void invokeValidations() {
            
            ModuleConfig.getValidateInput().ForEach(val => val.execute(this));
            
        }

    }
}
