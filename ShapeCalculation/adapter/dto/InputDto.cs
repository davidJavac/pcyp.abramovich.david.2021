using ShapeCalculation.adapter.validation;
using ShapeCalculation.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter.dto
{
    class InputDto : ValidationInvoker
    {
        private String shapeName;
        private String operation;
        private String values;

        public InputDto(String shapeName, String operation, String values) {
            this.shapeName = shapeName;
            this.operation = operation;
            this.values = values;
        }

        public string ShapeName { get => shapeName; set => shapeName = value; }
        public string Operation { get => operation; set => operation = value; }
        public String Values { get => values; set => values = value; }

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
