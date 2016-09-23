using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class China : ContentPage
	{
		public China()
		{
			InitializeComponent();
		}

		private async void ChinaReturnHome(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void CN1(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void CN2(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void CN3(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void CN4(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}
	}
}
