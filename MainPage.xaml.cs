
namespace AppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnHospedesChanged(object sender, ValueChangedEventArgs e)
    {
        HospedesLabel.Text = $"Hóspedes: {(int)e.NewValue}";
    }

    private void OnReservarClicked(object sender, EventArgs e)
    {
        string nome = NomeEntry.Text;
        int hospedes = (int)HospedesStepper.Value;

        string data = DataPicker.Date.ToString();

        string quarto = QuartoPicker.SelectedItem?.ToString();

        if (string.IsNullOrWhiteSpace(nome))
        {
            ResultadoLabel.Text = "Digite o nome do hóspede.";
            return;
        }

        if (string.IsNullOrEmpty(quarto))
        {
            ResultadoLabel.Text = "Selecione um tipo de quarto.";
            return;
        }

        ResultadoLabel.Text =
            $"Reserva realizada!\n" +
            $"Hóspede: {nome}\n" +
            $"Quantidade: {hospedes}\n" +
            $"Data: {data}\n" +
            $"Quarto: {quarto}";
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}
