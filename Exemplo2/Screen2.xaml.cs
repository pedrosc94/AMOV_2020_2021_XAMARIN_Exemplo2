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
    public partial class Screen2 : ContentPage
    {
        List<string> listaPalavras = new List<string> {
            "Transilvânia", "Joaninha", "Repetir", "Pequeno", "Medidor", "Farmácia", "Nota", "Ciclope","Departamento", "Maduro",
            "Bolhas", "Agenda", "Punido", "Remo", "Voleibol", "Larva","Plutão", "Varrer", "Viajar", "Resíduos",
            "Negócio", "Fungo", "Mexicano", "Uvas", "Estacionamento", "Enterrar","Mês", "Tronco", "Artista", "Medalhão"
        };
        public class ClassPalavra { public string Palavra { get; set; } }

        public Screen2()
        {
            InitializeComponent();

            //cria nova lista
            var ListaPalavras = new List<ClassPalavra>();

            //adiciona um novo elemento a list
            for (int i = 0; i < listaPalavras.Count ; i++)
            {
                ListaPalavras.Add(new ClassPalavra { Palavra = listaPalavras.ElementAt(i) });
            }
            //associa a lista criada ao ListView "listaScreen1" no XAML
            listaScreen2.ItemsSource = ListaPalavras;
        }
    }
}
