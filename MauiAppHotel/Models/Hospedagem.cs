using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    // A classe Quarto foi incluída aqui para simplificar.
    // Ela representa as opções de suite.
    public class Quarto
    {
        // Adicionamos '?' para indicar que Descricao pode ser nula
        public string? Descricao { get; set; }
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }
    }

    // A classe Hospedagem armazena todos os dados da reserva
    // e calcula o valor total.
    public class Hospedagem
    {
        // Propriedades para armazenar os dados da reserva
        // Adicionamos '?' para indicar que QuartoSelecionado pode ser nulo
        public Quarto? QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        // Propriedades calculadas
        public int Estadia
        {
            get
            {
                // Calcula a diferença em dias entre check-out e check-in
                int dias = DataCheckOut.Subtract(DataCheckIn).Days;
                return (dias == 0) ? 1 : dias; // Mínimo de 1 dia
            }
        }

        public double ValorTotal
        {
            get
            {
                // Verificação para evitar erro se QuartoSelecionado for nulo
                if (QuartoSelecionado == null)
                    return 0;

                // Calcula o valor total baseado nas diárias e quantidade de pessoas
                double valorAdultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valorCriancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                return (valorAdultos + valorCriancas) * Estadia;
            }
        }
    }
}