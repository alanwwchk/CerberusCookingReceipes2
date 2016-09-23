using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class Russia : ContentPage
	{
		public Russia()
		{
			InitializeComponent();
		}
		private async void RussiaReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void RU1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void RU2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void RU3(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void RU4(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}
	}
}
