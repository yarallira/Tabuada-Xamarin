using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tabuada
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCalcular_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Numero.Text);
            List<String> itens = new List<String>();
            String texto = "";
            for (int i = 0; i < 11; i++)
            {
                texto = n + " X " + i + " = " + (n * i);
                itens.Add(texto);
            }
            tabuada.ItemsSource = itens;
        }
    }
}
