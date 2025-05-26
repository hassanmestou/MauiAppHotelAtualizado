namespace MauiAppHotel1.Views;

public partial class desenvolvedor : ContentPage
{
	public desenvolvedor()
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
		} catch (Exception es)
		{
			await DisplayAlert("ERRO", es.Message, "Voltar");
		}
	}
}