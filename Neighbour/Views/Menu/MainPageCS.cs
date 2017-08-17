using System;
using Neighbour.Models.Menu;
using Neighbour.Views.NewsFeed;
using Xamarin.Forms;

namespace Neighbour.Views.Menu
{
	public class MainPageCS : MasterDetailPage
	{
		MasterPageCS masterPage;

		public MainPageCS()
		{
			masterPage = new MasterPageCS();
			Master = masterPage;
            Detail = new NavigationPage(new NewsFeedPage());

			masterPage.ListView.ItemSelected += OnItemSelected;

			if (Device.RuntimePlatform == Device.Windows)
			{
				MasterBehavior = MasterBehavior.Popover;
			}
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}
