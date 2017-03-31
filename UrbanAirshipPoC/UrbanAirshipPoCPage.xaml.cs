using System;
using Xamarin.Forms;
using UrbanAirship.Portable;

namespace UrbanAirshipPoC
{
	public partial class UrbanAirshipPoCPage : ContentPage
	{
		public UrbanAirshipPoCPage()
		{
			InitializeComponent();
		}

		void OnButtonClicked(object sender, EventArgs args){
			Airship.Instance.DisplayMessageCenter();
		}
	}
}
