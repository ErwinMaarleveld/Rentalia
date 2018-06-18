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
        public void VerstuurBericht(string text, Aanbieding onderwerp, Gebruiker ontvanger)
        {
            var a = new FieldCheckerMethod();
            a.AddBericht(text, onderwerp, ontvanger);
        }
	}
}