using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class Second : ContentPage
	{
		public Second()
		{
			InitializeComponent();
		}


		//all button clicked
		private async void Return_Click(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new CerberusCookingReceipes2Page());
		}

		private async void AustraliaClicked(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Australia());
		}

		private async void ChinaClicked(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new China());
		}

		private async void GreeceClicked(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Greece());
		}

		private async void ItalyClicked(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Italy());
		}

		private async void JapanClicked(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Japan());
		}

		private async void KoreaClicked(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Korea());
		}

		private async void RussiaClicked(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Russia());
		}

		private async void VietnamClicked(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Vitnam());
		}


	}
}
