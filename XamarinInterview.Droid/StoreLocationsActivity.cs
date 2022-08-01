
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using XamarinInterview.Shared;

namespace XamarinInterview.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class StoreLocationsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.store_locations);
            EditText zip = FindViewById<EditText>(Resource.Id.zipCode);
            Button button1 = FindViewById<Button>(Resource.Id.search);
            TextView view = FindViewById<TextView>(Resource.Id.results);
            RecyclerView recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            if (zip == null || zip.Text.Length < 6)
                view.Text = "Must enter valid zip code";

            button1.Click += (sender, e) => {
                StoreLocationsService storeLocServ  = new StoreLocationsService();
                var results = storeLocServ.SearchByZipCode(zip.Text);
                if (results == null)
                    view.Text = "Unable to find stores in your location";
                else
                {
                    DisplayResults dr = new DisplayResults();
                    dr.DisplayResultsToRecyclerView(results.Result, recyclerView);
                }
            };

            // TODO: update result RecyclerView with new RecyclerView.Adapter created from search results (if any);
            // or, display a message that no results were found;
            // or, display a message that an error has been encountered
        }
    }
}
