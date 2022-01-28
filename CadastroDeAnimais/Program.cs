using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAnimais
{
    public class Animal
    {
        private decimal idade;
        private decimal peso;

        public Animal()
        {
            this.Idade = 0;
            this.peso = 0;
        }

        public Animal(decimal idade, decimal peso)
        {
            this.Idade = idade;
            this.Peso = peso;
        }

        public decimal Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public decimal Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }
    }

    public class Gato : Animal
    {
        private string raca;

        public Gato()
        {
            this.Raca = "";
        }

        public Gato(decimal idade, decimal peso, string raca) : base(idade, peso)
        {
            this.Raca = raca;
        }

        public string Raca
        {
            get { return this.raca; }
            set { this.raca = value.ToUpper(); }
        }

        public override string ToString()
        {
            return $"Raça:{Raca} - {Idade}anos - {Peso}kg";
        }
    }

    public class Cachorro : Animal
    {
        private string nome;

        public Cachorro()
        {
            this.Nome = nome;
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public Cachorro(decimal idade, decimal peso, string nome) : base(idade, peso)
        {
            Nome = nome;
        }
        public override string ToString()
        {
            return $"Nome:{Nome} - {Idade}anos - {Peso}kg";
        }
    }

    public class Raposa : Animal
    {
        public Raposa(decimal idade, decimal peso) : base(idade, peso)
        { }
        public override string ToString()
        {
          return $"Raposa - {Idade}anos - {Peso}kg";
        }
    }
}
