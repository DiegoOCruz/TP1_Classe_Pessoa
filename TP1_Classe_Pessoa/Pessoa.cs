using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Classe_Pessoa
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;
        private string _cpf;

        public Pessoa()
        {


        }
        public Pessoa(string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;

        }

        public string Nome { get => _nome; set => _nome = value; }
        public int Idade { get => _idade; set => _idade = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
    }
}
