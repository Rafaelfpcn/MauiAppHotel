namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

	private async void btn_voltar_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}
