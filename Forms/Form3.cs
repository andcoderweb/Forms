using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Form3 : Form
    {
        Thread nt;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Anderson" && textBox2.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }


            else
                MessageBox.Show("Usuario ou senha errados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void novoform()
        {
            Application.Run(new Form4());
        }
    }
}
