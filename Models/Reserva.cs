using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Reserva {
        
        public List<Pessoa> Hospedes;
        public Suite Suite;
        public int DiasReservados;
    

    public void CadastrarHospedes(List<Pessoa> hospedes) {

        if(hospedes.Count > this.Suite.Capacidade) {

           throw new Exception($"Não é possível cadastrar os hospedes nessa suite, pois a quantidade de hospedes excedeu a capacidade da suite que é de {this.Suite.Capacidade} pessoas.");
        }

        this.Hospedes = new List<Pessoa>(hospedes);
    }

    public void CadastrarSuite(Suite suite) {

        this.Suite = suite;
    }

    public int ObterQuantidadedeHospedes() {

        return this.Hospedes.Count;
    }

    public decimal CalcularValorDiaria() {

        if(DiasReservados >= 10) {

       return (this.Suite.ValorDiaria * this.DiasReservados)*Convert.ToDecimal(0.9);

       }

       return (this.Suite.ValorDiaria * this.DiasReservados);

    }

    public Reserva(int diasReservados){
        this.DiasReservados = diasReservados;
    }


    }
}