using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Edicao
{
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public DataGridView.ExerciciosFinaisDataSet1.VendasRow vendasRow;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet11.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.exerciciosFinaisDataSet11.Carros);
         

            comboBox1.SelectedValue = vendasRow.Carro;
            numericUpDown1.Value = vendasRow.Quantidade;
            textBox2.Text = (vendasRow.Valor).ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            vendasRow.Carro = (int)comboBox1.SelectedValue;
            vendasRow.Quantidade = (int)numericUpDown1.Value;
            vendasRow.Valor = decimal.Parse(textBox2.Text);

            this.Close();
        }
    }
}
