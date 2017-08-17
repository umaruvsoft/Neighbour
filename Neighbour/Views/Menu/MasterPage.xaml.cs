using System.Collections.Generic;
using Neighbour.Models.Menu;
using Neighbour.Views.Announcements;
using Neighbour.Views.NewsFeed;
using Xamarin.Forms;

namespace Neighbour.Views.Menu
{
    public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage()
		{
			InitializeComponent();

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Announcemetns",
				IconSource = "tab_about.png",
				TargetType = typeof(AnnouncemetnsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "NewsFeed",
				IconSource = "tab_feed.png",
				TargetType = typeof(NewsFeedPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
