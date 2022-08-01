using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Java.Util;
using XamarinInterview.Shared;

namespace XamarinInterview.Droid
{
    public class ListAdapter : RecyclerView.Adapter
    {
        public List<StoreLocation> mLocations;

        public ListAdapter(List<StoreLocation> locations)
        {
            mLocations = locations;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ListViewHolder listView = holder as ListViewHolder;
            listView.Caption.Text = mLocations[position].Name;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                Inflate(Resource.Layout.store_locations, parent, false);

            // Create a ViewHolder to hold view references inside the CardView:
            ListViewHolder vh = new ListViewHolder(itemView);
            return vh;
        }

        public override int ItemCount { get; }
    }
}