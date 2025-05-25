namespace MauiAppHotel1.Views;

public partial class ContratacaoHospedagem : ContentPage
{


	
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

	private async void buttonpres(Object sender, EventArgs e)
	{
		try
		{
			if (sender != null)
			{
				await Navigation.PushAsync(new desenvolvedor());
			}
		}
		catch (Exception error)
		{
			await DisplayAlert("erro", "Erro em algum lugar", "Voltar");
		}
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			await Navigation.PushAsync(new HospedagemContratada()); 

		}
		catch (Exception ex)
		{
			await DisplayAlert("OPS", "ErR*", "EXIT");
		}
    }
}