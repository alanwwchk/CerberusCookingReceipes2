using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class Italy : ContentPage
	{
		public Italy()
		{
			InitializeComponent();
		}

		private async void ItalyReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void IT1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void IT2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void IT3(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void IT4(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}
	}
}
