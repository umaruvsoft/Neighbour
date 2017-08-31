using System;
using System.Collections.Generic;
using Neighbour.Models.Menu;
using Neighbour.Views.NewsFeed;
using Xamarin.Forms;

namespace Neighbour.Views.Menu
{
	public partial class MainPage : MasterDetailPage
	{
		MasterPage myMmasterPage;
		public MainPage()
		{
			InitializeComponent();

			//myMmasterPage = new MasterPage();
			//Master = myMmasterPage;
			//Detail = new NavigationPage(new NewsFeedPage());

			//myMmasterPage.ListView.ItemSelected += OnItemSelected;

            //if (Device.RuntimePlatform == Device.Windows)
            //{
            //    MasterBehavior = MasterBehavior.Popover;
            //}
        }

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				myMmasterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}
