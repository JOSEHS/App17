using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App17
{
	public partial class MainPage : ContentPage
	{
        List<Models1> ListaProdutos = new List<Models1>();
        MainViewModel _vm;

        public MainPage()
		{
			InitializeComponent();

            ListaProdutos.Add(new Models1 { Nome = "Home", Imagem = "twotone_receipt_black_24dp.png" });
            ListaProdutos.Add(new Models1 { Nome = "Dados Cadastrais", Imagem = "twotone_receipt_black_24dp.png" });
            ListaProdutos.Add(new Models1 { Nome = "teste", Imagem = "twotone_receipt_black_24dp.png" });
            ListaProdutos.Add(new Models1 { Nome = "teste", Imagem = "twotone_receipt_black_24dp.png" });
            ListaProdutos.Add(new Models1 { Nome = "Pagamento", Imagem = "twotone_receipt_black_24dp.png" });
            ListaProdutos.Add(new Models1 { Nome = "Cartão", Imagem = "twotone_receipt_black_24dp.png" });
            ListaProdutos.Add(new Models1 { Nome = "Teste", Imagem = "twotone_receipt_black_24dp.png" });
            Lista.ItemsSource = ListaProdutos;

            BindingContext = _vm = new MainViewModel();
        }

        void Handle_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            Debug.WriteLine("Position " + e.NewValue + " selected.");
        }

        void Handle_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        {
            Debug.WriteLine("Scrolled to " + e.NewValue + " percent.");
            Debug.WriteLine("Direction = " + e.Direction);
           
        }
    }
}
