using ShapeCalculation.adapter;
using ShapeCalculation.adapter.view;
using ShapeCalculation.adapter.view.implementation;
using ShapeCalculation.usecase.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter.implementation
{
    class PresenterResponse : ManageOutput
    {
        public void execute(OutputDto output)
        {
            ViewPresenter presenter = new ConsoleView();
            presenter.execute(output);
        }
    }
}
