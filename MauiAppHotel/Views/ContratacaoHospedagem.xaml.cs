using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    // Lista de quartos disponíveis
    private List<Quarto> lista_quartos = new List<Quarto>
    {
        new Quarto { Descricao = "Suíte Standard", ValorDiariaAdulto = 120.0, ValorDiariaCrianca = 60.0 },
        new Quarto { Descricao = "Suíte Luxo", ValorDiariaAdulto = 180.0, ValorDiariaCrianca = 90.0 },
        new Quarto { Descricao = "Suíte Premium", ValorDiariaAdulto = 250.0, ValorDiariaCrianca = 125.0 }
    };

    public ContratacaoHospedagem()
    {
        InitializeComponent();
        pck_quarto.ItemsSource = lista_quartos;
        pck_quarto.SelectedIndex = 0; // Pré-seleciona o primeiro item

        // Define as datas mínimas
        dtp_checkin.MinimumDate = DateTime.Now;
        dtp_checkout.MinimumDate = DateTime.Now.AddDays(1);
    }

    private async void btn_calcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Validação simples
            if (dtp_checkout.Date <= dtp_checkin.Date)
            {
                await DisplayAlert("Erro", "A data de Check-out deve ser maior que a data de Check-in.", "OK");
                return;
            }

            // Cria o objeto Hospedagem com os dados da tela
            Hospedagem model = new Hospedagem()
            {
                QuartoSelecionado = pck_quarto.SelectedItem as Quarto,
                QntAdultos = (int)stp_adultos.Value,
                QntCriancas = (int)stp_criancas.Value,
                DataCheckIn = dtp_checkin.Date,
                DataCheckOut = dtp_checkout.Date
            };

            // Navega para a tela de Resumo, passando o modelo como BindingContext
            // Isso permite que a próxima tela acesse os dados (ValorTotal, Estadia, etc.)
            await Navigation.PushAsync(new HospedagemContratada
            {
                BindingContext = model
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Ocorreu um erro: " + ex.Message, "OK");
        }
    }
}