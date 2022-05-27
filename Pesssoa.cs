using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula27_05
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private double altura;

        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
        }

        public Pessoa(string nome, int idade, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public override string ToString()
        {
            return (String.Format("Nome: {0} \n Idade: {1} \n Altura: {2}",
                                  nome, idade, altura));
        }
    }

}