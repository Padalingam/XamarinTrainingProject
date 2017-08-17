
using HelloWord.iOS;
using Helloworld;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfoOne))]
namespace HelloWord.iOS
{
	public class DeviceInfoOne : IDeviceInfo
	{
		public string GetUniqueIdentifier()
		{
			//return "Dummy return";
			return UIDevice.CurrentDevice.IdentifierForVendor.AsString();
		}
	}
}
