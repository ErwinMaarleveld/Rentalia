using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rentalia.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rentalia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessageLayout : ContentView
	{
		public MessageLayout ()
		{
			InitializeComponent ();
		}
        public Bericht VerstuurBericht(string tekst)
        {
            var a = new FieldCheckerMethod();
            Bericht nieuwBericht = a.AddBericht(tekst, );
        }
	}
}