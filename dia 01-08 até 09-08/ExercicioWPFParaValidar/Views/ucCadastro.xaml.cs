using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExercicioWPFParaValidar.Views
{
    /// <summary>
    /// Interaction logic for ucCadastro.xaml
    /// </summary>
    public partial class ucCadastro : UserControl
    {
        public ucCadastro()
        {
            InitializeComponent();
        }

        private void salve_Click(object sender, RoutedEventArgs e)
        {
            Cadastro(tbxNome.Text, tbxTelefone.Text, tbxEmail.Text);
        }

        public void Cadastro(string nome, string numero, string email)
        {
            ucCadastro cadastro = new ucCadastro();

             nome = (cadastro.tbxNome).ToString();
             numero = (cadastro.tbxTelefone).ToString();
             email = (cadastro.tbxEmail).ToString();

            var stringRegEmail = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
            var stringRegTelefone = @"^(\+55) \([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$";

            Regex regexTelefone = new Regex(stringRegTelefone);
            var matchTelefone = regexTelefone.IsMatch(numero);

            Regex regexEmail = new Regex(stringRegEmail);
            var matchEmail = regexEmail.IsMatch(email);


            if (matchTelefone)
            {
                MessageBox.Show("Telefone correto");
            }
            if (matchEmail)
            {
                MessageBox.Show("Email correto");
            }
        }
    }
}
