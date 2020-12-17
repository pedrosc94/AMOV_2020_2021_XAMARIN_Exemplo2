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
    public partial class Screen1 : ContentPage
    {

        public class ListaClassNumeros
        {
            public int Numero { get; set; }
        }

        public Screen1()
        {
            InitializeComponent();

            //cria nova lista
            var ListaNumeros = new List<ListaClassNumeros>();
            //adiciona um novo elemento a list
            for (int i = 1; i<=1000; i++)
            {
                ListaNumeros.Add(new ListaClassNumeros { Numero = i });
            }
            //associa a lista criada ao ListView "listaScreen1" no XAML
            listaScreen1.ItemsSource = ListaNumeros;
        }
    }
}