using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVarios.Telas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVarios.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelaInicio : ContentPage
	{
        public async void botaoLivro_Clicked(object sender, EventArgs e)
        {
            Telas.CadastrarLivro.Show();
        }
		public TelaInicio ()
		{
			InitializeComponent ();
		}
	}
}