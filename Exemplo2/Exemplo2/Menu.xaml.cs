using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exemplo2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Buttons Events
        private void ButtonScreen1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Screen1());
            Console.WriteLine("ButtonScreen1_Clicked");
        }

        private void ButtonScreen2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Screen2());
            Console.WriteLine("ButtonScreen2_Clicked");
        }
        private void ButtonScreen3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Screen3());
            Console.WriteLine("ButtonScreen3_Clicked");
        }
    }
}