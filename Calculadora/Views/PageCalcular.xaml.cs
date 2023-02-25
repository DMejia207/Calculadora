using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCalcular : ContentPage
    {
        int nume1;
        int nume2;
        double resp;
        public PageCalcular()
        {
            InitializeComponent();
        }

        private async void btnsumar_Clicked(object sender, EventArgs e)
        {
            nume1 = int.Parse(num1.Text);
            nume2 = int.Parse(num2.Text);
            resp = nume1 + nume2;
            await DisplayAlert("Suma", "La Respuesta es: " +resp ,"Ok" );

        }
        private async void btnrestar_Clicked(object sender, EventArgs e)
        {
            nume1 = int.Parse(num1.Text);
            nume2 = int.Parse(num2.Text);
            resp = nume1 - nume2;
            await DisplayAlert("Resta", "La Respuesta es: " + resp, "Ok");

        }
        private async void btndividir_Clicked(object sender, EventArgs e)
        {
            nume1 = int.Parse(num1.Text);
            nume2 = int.Parse(num2.Text);
            resp = nume1 / nume2;
            await DisplayAlert("Division", "La Respuesta es: " + resp, "Ok");

        }
        private async void btnmulti_Clicked(object sender, EventArgs e)
        {
            nume1 = int.Parse(num1.Text);
            nume2 = int.Parse(num2.Text);
            resp = nume1 * nume2;
            await DisplayAlert("Multiplicacion", "La Respuesta es: " + resp, "Ok");

        }

    }
}