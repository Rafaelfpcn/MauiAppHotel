using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto() { Descricao = "Suíte Standard", ValorDiariaAdulto = 80, ValorDiariaCrianca = 40 },
            new Quarto() { Descricao = "Suíte Luxo", ValorDiariaAdulto = 120, ValorDiariaCrianca = 60 },
            new Quarto() { Descricao = "Suíte Master", ValorDiariaAdulto = 180, ValorDiariaCrianca = 90 },
            new Quarto() { Descricao = "Suíte Presidencial", ValorDiariaAdulto = 300, ValorDiariaCrianca = 150 }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
