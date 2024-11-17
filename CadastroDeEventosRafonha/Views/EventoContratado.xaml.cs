namespace CadastroDeEventosRafonha.Views;

public partial class EventoContratado : ContentPage
{
    public EventoContratado()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Voltar para a página anterior
        await Navigation.PopAsync();
    }
}
