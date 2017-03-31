using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using UrbanAirship;

namespace UrbanAirshipPoC.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			UAirship.TakeOff ();
			UAirship.Push.UserPushNotificationsEnabled = true;
			UAirship.InAppMessaging.DisplayASAPEnabled = true;
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
