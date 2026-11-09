namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

	private async void btn_voltar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
