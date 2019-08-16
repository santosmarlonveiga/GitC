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
    public partial class CadastroDosAlunos : Form
    {

        public Alunos novoAluno = new Alunos();

        public CadastroDosAlunos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = tbxNome.Text;
            novoAluno.Idade = int.Parse(tbxIdade.Text);

            MessageBox.Show("Cadastro realizado com sucesso!!");

            
        }
    }
}
