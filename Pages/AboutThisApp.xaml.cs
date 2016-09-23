using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class AboutThisApp : ContentPage
	{
		public AboutThisApp()
		{
			InitializeComponent();
		}

		private async void ReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new CerberusCookingReceipes2Page());
		}
	}
}
