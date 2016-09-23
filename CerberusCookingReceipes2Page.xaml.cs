using System;
using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public partial class CerberusCookingReceipes2Page : ContentPage
	{
		public CerberusCookingReceipes2Page()
		{
			InitializeComponent();

			/*var backgroundImage = new Image { Aspect = Aspect.AspectFit };
			backgroundImage.Source = ImageSource.FromFile("background.jpg");
			Device.OnPlatform(
				iOS: ImageSource.FromFile("Images/background.jpg"),
				Android: ImageSource.FromFile("background.jpg"));*/

			
		}

		private async void TooReceipesSelection(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new Second());
		}

		private async void TooAboutThisApp (object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new AboutThisApp());
		}

		private async void TooContactUs(object sender, EventArgs args)
		{
			await Navigation.PushModalAsync(new ContactUs());
		}
	}
}
