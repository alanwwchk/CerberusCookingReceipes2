using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class Vitnam : ContentPage
	{
		public Vitnam()
		{
			InitializeComponent();
		}
		private async void VitnamReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void VN1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void VN2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void VN3(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void VN4(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}
	}
}
