using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace XamarinInterview.Droid
{
    public class ListViewHolder : RecyclerView.ViewHolder
    {
        public TextView Caption { get; private set; }

        public ListViewHolder(View itemView) : base(itemView)
        {
            // Locate and cache view references:
            Caption = itemView.FindViewById<TextView>(Resource.Id.results);
        }
    }
}