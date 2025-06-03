using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        List<int> NumerosRestantes = new List<int>();
        List<int> NumerosSorteados = new List<int>();
        List<Panel> bingoPanels = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            InicializarBingo();
        }
        void InicializarBingo()
        {
            NumerosRestantes.Clear();
            NumerosSorteados.Clear();

            for (int i = 1; i <= 75; i++) { 
                NumerosRestantes.Add(i);
            }
            lblNumeroAnterior.Text = "";
            lblNumeroAtual.Text = "";
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_sortear_Click(object sender, EventArgs e)
        {
            if (NumerosRestantes.Count == 0) {
                MessageBox.Show("Todos os números foram sorteados");
                return;
            }

            Random Sorteio = new Random();
            int numero = Sorteio.Next(NumerosRestantes.Count);
            int numSorteado = NumerosRestantes[numero];
            NumerosRestantes.RemoveAt(numero);
            if (NumerosSorteados.Count > 0) {
                lblNumeroAnterior.Text = NumerosSorteados[NumerosSorteados.Count - 1].ToString();   
            }
            lblNumeroAtual.Text=numSorteado.ToString();
            NumerosSorteados.Add(numSorteado);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNumeroAnterior_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroAtual_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
