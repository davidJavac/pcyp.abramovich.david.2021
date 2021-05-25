using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            txtEstado.Text = "Ejecutando...";

            Task<int> calcTemperatureA = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                return 10;
            });

            Task<int> calcTemperatureB = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                return 35;
            });

            Task<int> calcTemperatureC = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                return 14;
            });

            Task<double> taskAverage = Task.Factory.ContinueWhenAll<int, double>(
                new[] { calcTemperatureA, calcTemperatureB, calcTemperatureC },
                (tasks) =>
                {
                    return (calcTemperatureA.Result + calcTemperatureB.Result + calcTemperatureC.Result) / 3;
                });

            resultado.Text = taskAverage.Result.ToString();
            txtEstado.Text = "Finalizó";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
