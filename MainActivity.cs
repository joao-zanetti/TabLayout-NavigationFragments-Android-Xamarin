using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;
using Android.Support.V4.View;

namespace TabNavigation
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        ViewPager viewPager;
        TabLayout tabLayout;
        Adapter_Fragment adapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            tabLayout = FindViewById<TabLayout>(Resource.Id.tabLayout);

            tabLayout.SetupWithViewPager(viewPager);
            adapter = new Adapter_Fragment(SupportFragmentManager);
            viewPager.Adapter = adapter;

            tabLayout.GetTabAt(0).SetIcon(Resource.Drawable.tooltip_frame_dark);
            tabLayout.GetTabAt(0).SetText("tab0");
            tabLayout.GetTabAt(1).SetIcon(Resource.Drawable.tooltip_frame_light);
            tabLayout.GetTabAt(1).SetText("tab1");

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}