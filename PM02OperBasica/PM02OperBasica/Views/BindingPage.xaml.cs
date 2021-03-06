using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02OperBasica.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingPage : ContentPage
    {
        public BindingPage()
        {
            InitializeComponent();
        }

        private async void btnbinding_Clicked(object sender, EventArgs e)
        {
            var personas = new Models.Personas
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                Correo = txtcorreo.Text,
                Direccion = txtdireccion.Text
            };
            var SecondPage = new Views.ResultPage { };
            SecondPage.BindingContext = personas;
            await Navigation.PushAsync(SecondPage);


        }
    }
}