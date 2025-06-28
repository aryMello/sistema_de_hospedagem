using System;
using System.Collections.Generic;
using SistemaReservaHotel.Models;

namespace SistemaReservaHotel
{
    class Program
    {
        static void Main()
        {
            // Criar lista para os hóspedes
            var hospedes = new List<Pessoa>();

            // Solicitar o número de hóspedes
            Console.WriteLine("Digite o número de hóspedes:");
            int numeroDeHospedes = int.Parse(Console.ReadLine());

            // Coletar informações sobre os hóspedes
            for (int i = 0; i < numeroDeHospedes; i++)
            {
                Console.WriteLine($"Digite o nome do hóspede {i + 1}:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite a idade do hóspede {i + 1}:");
                int idade = int.Parse(Console.ReadLine());

                // Criar e adicionar o hóspede à lista
                var hospede = new Pessoa(nome, idade);
                hospedes.Add(hospede);
            }

            // Solicitar o número de dias da reserva
            Console.WriteLine("Digite o número de dias da reserva:");
            int diasReservados = int.Parse(Console.ReadLine());

            // Criar uma suíte (exemplo de suíte Premium)
            var suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 300);

            // Criar uma reserva
            var reserva = new Reserva(diasReservados);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            // Exibir informações da reserva
            Console.WriteLine($"\nQuantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor total da reserva: R$ {reserva.CalcularValorDiaria():F2}");
        }
    }
}
