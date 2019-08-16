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
    public partial class LixeiraVendas : Form
    {
        public LixeiraVendas()
        {
            InitializeComponent();
        }

        private void LixeiraVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomInativeValues(this.exerciciosFinaisDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasAcres = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridView.ExerciciosFinaisDataSet1.VendasRow;


            this.vendasTableAdapter.AcresQuery(vendasAcres.Id);
            this.vendasTableAdapter.CustomInativeValues(exerciciosFinaisDataSet1.Vendas);
        }
    }
}
