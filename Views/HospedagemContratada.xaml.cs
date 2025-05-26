namespace MauiAppHotel1.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			if (sender != null)
			{
				await Navigation.PushAsync(new ContratacaoHospedagem());
			}
		}catch (Exception ex)
		{
			await DisplayAlert("OPS", ex.Message, "VOLTAR");
		}
    }
}