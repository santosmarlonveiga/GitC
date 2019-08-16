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
    public partial class EdicaoMarcas : Form
    {
        public EdicaoMarcas()
        {
            InitializeComponent();
        }

        public DataGridView.ExerciciosFinaisDataSet1.MarcasRow marcasRow;

        private void EdicaoMarcas_Load(object sender, EventArgs e)
        {
            textBox1.Text = marcasRow.Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            marcasRow.Nome = textBox1.Text;

            this.Close();
        }
    }
}
