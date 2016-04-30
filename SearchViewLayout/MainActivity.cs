using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace SearchViewLayout
{
	[Activity (Label = "SearchViewLayout", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
			SetSupportActionBar (toolbar);
		}
	}
}