using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularnotas
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

        private void btncalcular_Click(object sender, EventArgs e)
        {
          int nota1, nota2, nota3, nota4, resultado;
            nota1 = Convert.ToInt16(txtnota1.Text);
            nota2 = Convert.ToInt16(txtnota2.Text);
            nota3 = Convert.ToInt16(txtnota3.Text);
            nota4 = Convert.ToInt16(txtnota4.Text);

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;
            MessageBox.Show("O resultado é: " + resultado);
        }

        private void txtnota4_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Tem certeza que deseja fechar essa janela?", "Confirmar", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
