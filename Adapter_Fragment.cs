using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace TabNavigation
{
    class Adapter_Fragment : FragmentPagerAdapter
    {
        public string[] titles = new string[] { "Tab1", "Tab2"};
        List<Android.Support.V4.App.Fragment> fgs = new List<Android.Support.V4.App.Fragment>();

        public Adapter_Fragment(Android.Support.V4.App.FragmentManager fm)
            : base(fm)
        {
            fgs.Add(Fragment_1.NewInstance());
            fgs.Add(Fragment_2.NewInstance());
            //fgs.Add(Fragment_3.NewInstance());
        }

        public override int Count
        {
            get { return titles.Length; }
        }


        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return fgs[position];
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(titles[position]);
        }



    }
}