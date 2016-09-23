using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class Greece : ContentPage
	{
		public Greece()
		{
			InitializeComponent();
		}
		private async void GreeceReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void GC1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void GC2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void GC3(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void GC4(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}
	}
}
