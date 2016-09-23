using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class Australia : ContentPage
	{
		public Australia()
		{
			InitializeComponent();
		}

		private async void AustraliaReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void AU1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Detail());
		}

		private async void AU2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void AU3(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void AU4(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}
	}
}
