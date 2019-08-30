using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class LixeiraMarcas : Form
    {
        public LixeiraMarcas()
        {
            InitializeComponent();
        }

        private void LixeiraMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomInativeValues(this.exerciciosFinaisDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasAcres = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridView.ExerciciosFinaisDataSet1.MarcasRow;


            this.marcasTableAdapter.AcresQuery(marcasAcres.Id);
            this.marcasTableAdapter.CustomInativeValues(exerciciosFinaisDataSet1.Marcas);
        }
    }
}
