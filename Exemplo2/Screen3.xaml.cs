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
    public partial class Screen3 : ContentPage
    {
        int quantidade = 15;
        public class ClassListaImagemTextoNumero
        {
            public ImageSource Imagem { get; set; }
            public string Texto { get; set; }
            public int Numero { get; set; }
        }
        public Screen3()
        {
            InitializeComponent();

            var ListaImagemTextoNumero = new List<ClassListaImagemTextoNumero>();
            for (int i = 1; i <= quantidade; i++)
            {
                ListaImagemTextoNumero.Add(new ClassListaImagemTextoNumero
                {
                    Imagem = ImageSource.FromResource("Exemplo2.Images." + "dino" + ".png"),
                    Texto = "Texto",
                    Numero = i
                });
            }
            listaScreen3.ItemsSource = ListaImagemTextoNumero;
        }
    }
}