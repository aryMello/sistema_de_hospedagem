using System;
using System.Collections.Generic;

namespace HotelReservationSystem.Models
{
    public class Reserva
    {
        public Suite SuiteReservada { get; set; }
        public List<Pessoa> Hospedes { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarSuite(Suite suite)
        {
            SuiteReservada = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= SuiteReservada.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * SuiteReservada.ValorDiaria;

            // Aplicar desconto de 10% para reservas acima de 10 dias
            if (DiasReservados > 10)
            {
                valor *= 0.90m; // Desconto de 10%
            }

            return valor;
        }
    }
}
