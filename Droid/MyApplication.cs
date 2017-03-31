using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using UrbanAirship;
using UrbanAirship.Portable;

[Application]
public class MyApplication : Application
{

	public MyApplication(IntPtr handle, JniHandleOwnership transfer)
		: base(handle, transfer)
	{
		// do any initialisation you want heexample initialising properties)
	}




	public override void OnCreate()
	{
		base.OnCreate();
		UAirship.TakeOff(this, (UAirship airship) =>
		{
			// Configure airship here
		});
		UAirship.Shared().PushManager.UserNotificationsEnabled = true;
		UAirship.Shared().InAppMessageManager.DisplayAsapEnabled = true;
		String channelId = UAirship.Shared().PushManager.ChannelId;
 		System.Diagnostics.Debug.WriteLine(channelId);
	}
}

public class SampleAirshipReceiver : AirshipReceiver { 
	protected override void OnChannelCreated(Context p0, string p1)
	{
		base.OnChannelCreated(p0, p1);
		System.Diagnostics.Debug.WriteLine(p1);
	}
	protected override void OnChannelRegistrationFailed(Context p0)
	{
		base.OnChannelRegistrationFailed(p0);
		System.Diagnostics.Debug.WriteLine("FAILLLL");
	}
}