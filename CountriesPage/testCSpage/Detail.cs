using System;

using Xamarin.Forms;

namespace CerberusCookingReceipes2
{
	public class Detail : ContentPage
	{
		public Detail()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "This is the Detail page" }
				}
			};
		}
	}
}

