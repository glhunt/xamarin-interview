using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using XamarinInterview.Droid;
using XamarinInterview.Shared;

namespace XamarinInterview.Droid
{
    public class DisplayResults
    {
        public void DisplayResultsToRecyclerView(List<StoreLocation> storeList, RecyclerView recyclerView)
        {
            StoreListAdapter listAdapter = new StoreListAdapter(storeList);
            recyclerView.SetAdapter(listAdapter);
            recyclerView.Visibility = ViewStates.Visible;
        }

    }
}