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

			var searchViewLayout = FindViewById<Xyz.Sahildave.Widget.SearchViewLayout> (Resource.Id.search_view_container);
			searchViewLayout.ToggleAnimationStarted += (sender, e) =>
			{
				if (e.Expanding)
				{
				}
				else
				{
				}
			};
		}

		void SearchViewLayout_Start (object sender, Xyz.Sahildave.Widget.SearchViewLayout.StartEventArgs e)
		{
		}
	}
}