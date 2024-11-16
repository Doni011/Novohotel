using MauiAppHotel1.Models;
using System.Data;

namespace MauiAppHotel1.Views
{
    public partial class Contratacaohospedagem : ContentPage
    {
        App propriedadesApp;
        public Contratacaohospedagem()
        {
            InitializeComponent();

            propriedadesApp = (App)Application.Current;

            pck_quarto.ItemsSource = propriedadesApp.lista_quartos;

            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Navegar para a página "SobrePage"
            await Navigation.PushAsync(new Sobrepage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Hospedagem h = new Hospedagem

                {
                    QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                    QntAdultos = Convert.ToInt32(stp_adultos.Value),
                    QntCriancas = Convert.ToInt32(stp_criancas.Value),
                    DataCheckin = dtpck_checkin.Date,
                    DataCheckOut = dtpck_checkout.Date,
                };

                await Navigation.PushAsync(new Hospedagemcontratada()

                {
                    BindingContext = h
                });

            }
            catch (Exception ex)

            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_checkin = elemento.Date;

            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
        }
    }
}