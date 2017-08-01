using Xamarin.Forms;

namespace Helloworld
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new Content_Page();
				//new TabPage();
				//new Drawing();
				//new DrawPage();
				//new NavigationPage(new ProgressBarPage());
				//new NavigationPage(new ProductPage());
				//new Master_Page();
				//new TabPage();
				//new NavigationPage(new Content_Page());
				//new AnimationPage();
				//new Gestures();
				//new ListView();
				//new DataBinding();
				//new ListView();
				//new GridLayout();
				//new RelativeLayout();
				//new AbsolutePage();
				//new ScrollPage();
				//new HelloworldPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
