using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class ContactUs : ContentPage
	{
		public ContactUs()
		{
			InitializeComponent();
		}

		private async void TooHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new CerberusCookingReceipes2Page());
		}


	}
}
