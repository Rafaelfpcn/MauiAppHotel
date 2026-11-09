namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();

		pck_quarto.ItemsSource = new List<string>
		{
			"Suíte Standard",
			"Suíte Luxo",
			"Suíte Master",
			"Suíte Presidencial"
		};

		dtpck_checkin.MinimumDate = DateTime.Today;
		dtpck_checkin.MaximumDate = DateTime.Today.AddMonths(6);

		dtpck_checkout.MinimumDate = DateTime.Today.AddDays(1);
		dtpck_checkout.MaximumDate = DateTime.Today.AddMonths(6).AddDays(1);
		dtpck_checkout.Date = dtpck_checkout.MinimumDate;
	}

	private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
	{
		// No .NET 10 a data é DateTime? (pode ser nula)
		DateTime checkin = e.NewDate ?? DateTime.Today;

		// Check-out precisa ser pelo menos 1 dia depois do check-in
		dtpck_checkout.MinimumDate = checkin.AddDays(1);
		dtpck_checkout.MaximumDate = checkin.AddMonths(6);
	}

	private async void btn_sobre_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}
