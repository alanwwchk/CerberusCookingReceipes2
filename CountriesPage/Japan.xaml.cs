using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class Japan : ContentPage
	{
		public Japan()
		{
			InitializeComponent();
		}
		private async void JapanReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void JP1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void JP2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void JP3(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void JP4(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}
	}
}
