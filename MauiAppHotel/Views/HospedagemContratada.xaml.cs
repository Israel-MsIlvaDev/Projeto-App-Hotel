namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }

    private async void btn_nova_reserva_Clicked(object sender, EventArgs e)
    {
        try
        {
            // O método PopAsync() remove a página atual (Resumo)
            // e retorna para a página anterior (Contratação).
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Ocorreu um erro ao voltar: " + ex.Message, "OK");
        }
    }
}