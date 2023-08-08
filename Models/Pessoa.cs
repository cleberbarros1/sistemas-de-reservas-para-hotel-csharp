using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        { 
            get => _nome;

            set {

                if(value == "") {
                    throw new ArgumentException("O campo nome não pode ser nulo.");
                }
                this._nome = value;

                }
        }

        private string _sobreNome;
        public string SobreNome 
        { 
            get => _sobreNome;

            set {

                if(value == "") {
                    throw new ArgumentException("O campo nome não pode ser nulo.");
                }
                this._sobreNome = value;

                }
        }

        public Pessoa(string nome) {
            this.Nome = nome;
        }
        
    }
}