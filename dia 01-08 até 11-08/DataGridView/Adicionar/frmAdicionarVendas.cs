using DataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Adicionar
{
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }
        public Vendas vendasRow;

        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.exerciciosFinaisDataSet1.Usuarios);
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.exerciciosFinaisDataSet1.Carros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Informe quantidade");
                numericUpDown1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Informe valor");
                textBox1.Focus();
                return;
            }
            decimal.TryParse(textBox1.Text, out decimal valor);

            vendasRow = new Vendas
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = (int)numericUpDown1.Value,
                Valor = valor,
                UsuInc = (int)comboBox1.SelectedValue
            };
            this.Close();
        }
    }
}
