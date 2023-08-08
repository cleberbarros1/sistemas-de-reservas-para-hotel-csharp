using Models;

// Criar a lista de hospedes baseado na classe pessoa.
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Pessoa 1");
Pessoa p2 = new Pessoa(nome: "Pessoa 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Instância de uma suite
Suite suite = new Suite(tipoSuite: "Premium Top", capacidade: 10, valorDiaria: Convert.ToDecimal(30));

//Instancia de uma reserva com base na Lista de Hospedes e na suite.

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


//Exibe a quantidade de hospedes e o valor da diária
Console.WriteLine($"Quantidades de Hospesdes: {reserva.ObterQuantidadedeHospedes()}");
Console.WriteLine($"Valor da diária: R$ {reserva.CalcularValorDiaria()}");
