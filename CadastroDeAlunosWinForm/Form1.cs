using CadastroDeAlunosWinForm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAlunosWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Alunos> alunos = new List<Alunos>();

        private void Button1_Click(object sender, EventArgs e)
        {
            CadastroDosAlunos formCad = new CadastroDosAlunos();
            formCad.ShowDialog();
            alunos.Add(formCad.novoAluno);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alunos;
            
        }
    }
}
