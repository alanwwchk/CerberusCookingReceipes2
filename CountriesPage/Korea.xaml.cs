using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class Korea : ContentPage
	{
		public Korea()
		{
			InitializeComponent();
		}

		private async void KoreaReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void KR1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void KR2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void KR3(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void KR4(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}
	}
}
