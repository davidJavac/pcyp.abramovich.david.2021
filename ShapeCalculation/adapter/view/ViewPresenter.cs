using ShapeCalculation.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter.view
{
    interface ViewPresenter
    {
        public void execute(OutputDto outpu);
    }
}
