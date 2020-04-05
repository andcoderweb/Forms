using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            DateTime dataNascimento = dateTimePicker1.Value;
            string cidade = comboBox1.Text;
            bool sexo1, sexo2;
            sexo1 = raiomas.Checked;
            sexo2 = radioButton2.Checked;
            int numeroCadastro =Convert.ToInt16(textBox2.Text);
            var res = $"Nome:{nome},Data-Nas:{dataNascimento},Cidade:{cidade},Sexo:{sexo1},{sexo2},Numero Cadastro{numeroCadastro}";
            MessageBox.Show(res, "Aviso", MessageBoxButtons.OK);
        }
    }
}

