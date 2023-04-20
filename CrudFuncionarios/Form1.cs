using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudFuncionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.id = Int32.Parse(txt_idFuncionario.Text);
            funcionario.nome = txt_nome.Text;
            funcionario.endereco = txt_endereco.Text;
            funcionario.dataNascimento = txt_dataNascimento.Text;
            funcionario.estadoCivil = txt_estadoCivil.Text;
            funcionario.telefone = Int32.Parse(txt_telefone.Text);
            funcionario.login = txt_login.Text;
            funcionario.senha = txt_senha.Text;
            funcionario.cargo = txt_cargo.Text;


        }
    }
}
