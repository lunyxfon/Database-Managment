using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SemenovIA.Task1.V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonVrachiSemenovIA_Click(object sender, EventArgs e)
        {
            var vrachiform=new VrachiFormSemenovIA();
            vrachiform.Show();
        }

        private void buttonBolnyeSemenovIA_Click(object sender, EventArgs e)
        {
            var bolnyeform= new BolnyeFormSemenovIA();
            bolnyeform.Show();
        }

        private void buttonOtziviSemenovIA_Click(object sender, EventArgs e)
        {
            var otziviform = new EditFormSemenovIA();
            otziviform.Show();
        }

        private void buttonCloseSemenovIA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
