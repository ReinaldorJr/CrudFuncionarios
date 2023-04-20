using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFuncionarios
{
    internal class Funcionario
    {
        public int id { get; set; }
        public double cpf { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string dataNascimento { get; set; }
        public string estadoCivil { get; set; }
        public int telefone { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string cargo { get; set; }
        public decimal salario { get; set; }
    }
}
