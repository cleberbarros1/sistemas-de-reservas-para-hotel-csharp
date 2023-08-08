using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Suite
    {

        public string TipoSuite;
        public int Capacidade;
        public decimal ValorDiaria;
        
    

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria) {

        this.TipoSuite = tipoSuite;
        this.Capacidade = capacidade;
        this.ValorDiaria = valorDiaria;

    }

    }
}