using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02OperBasica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage(Decimal Resultado)
        {
            InitializeComponent();
            lbresultado.Text = Resultado.ToString();


        }
    }
}