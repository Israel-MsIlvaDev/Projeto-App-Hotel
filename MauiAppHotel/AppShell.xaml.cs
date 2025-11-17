using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Precisamos registrar a rota para a tela de Resumo (HospedagemContratada)
        // Isso permite que a tela de Contratação consiga navegar para ela
        // usando o comando Navigation.PushAsync()
        Routing.RegisterRoute(nameof(HospedagemContratada), typeof(HospedagemContratada));
    }
}