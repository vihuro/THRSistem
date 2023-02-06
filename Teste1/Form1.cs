using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR;

namespace Teste1
{
    public partial class Form1 : Form
    {
        SistemaTHR.Apllication.Compras.frmRequisicaoCompra compras;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            compras = new SistemaTHR.Apllication.Compras.frmRequisicaoCompra();
            compras.Show();
        }
    }
}
