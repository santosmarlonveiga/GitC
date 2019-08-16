using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVisualizaçãoDeValores.Model;

namespace TabelaDeVisualizaçãoDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contrac> listaContracts = new List<Contrac>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            listaContracts.Add(new Contrac()
            {
                Id = listaContracts.Count,
                Value = new Random().Next(100),
                DatInc = DateTime.Now
            }) ;

            var newList = new List<Contrac>();
            foreach (Contrac item in listaContracts)
                newList.Add(new Contrac()
                {
                    Id = item.Id,
                    Value = item.Value,
                    DatInc = item.DatInc
                });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaContracts;
        }


        

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var columId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var collValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                switch (e.ColumnIndex)
                {
                    case 0:
                        {
                            MessageBox.Show("Não é possivel ajustar esta coluna.");
                        } break;
                    case 1:
                        {
                            if (MessageBox.Show("Deseja realmente ajustar esse valor?"
                            , "Edição"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question) == DialogResult.Yes) ;
                            {
                                listaContracts.FirstOrDefault(x =>
                                x.Id == (int)columId.Value).Value = (int)columId.Value;
                            }
                        }
                        break;
                            

                }
            }
                
        }
    }
}
