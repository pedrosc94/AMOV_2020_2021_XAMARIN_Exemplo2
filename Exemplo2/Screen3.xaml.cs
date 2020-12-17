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
        public class ListaClassImagemNomeNumero
        {
            public Image Imagem { get; set; }
            public String Nome { get; set; }
            public int Numero{ get; set; }
        }
        public Screen3()
        {
            InitializeComponent();

            var ListaImagemNomeNumero = new List<ListaClassImagemNomeNumero>();
            for (int i = 0; i <= quantidade; i++)
            {
                ListaImagemNomeNumero.Add(new ListaClassImagemNomeNumero
                {
                    Imagem = "something_here.jpg",//verificar isto
                    Nome = "test",
                    Numero = i
                });
            }
        }
    }
}