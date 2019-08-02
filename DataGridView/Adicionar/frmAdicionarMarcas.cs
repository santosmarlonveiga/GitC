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
    public partial class frmAdicionarMarcas : Form
    {
        public frmAdicionarMarcas()
        {
            InitializeComponent();
        }
        public Marcas marcasRow;

        private void FrmAdicionarMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.exerciciosFinaisDataSet1.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            marcasRow = new Marcas
            {
                Nome = textBox1.Text,
                UsuInc = (int)comboBox1.SelectedValue
            };

            this.Close();

        }
    }
}
