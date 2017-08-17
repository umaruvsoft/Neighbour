using System;
using System.Collections.Generic;
using Neighbour.Models.Menu;
using Neighbour.Views.Announcements;
using Neighbour.Views.NewsFeed;
using Xamarin.Forms;

namespace Neighbour.Views.Menu
{
    public class MasterPageCS: ContentPage
    {
		public ListView ListView { get { return listView; } }

		ListView listView;

		public MasterPageCS()
		{
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

			listView = new ListView
			{
				ItemsSource = masterPageItems,
				ItemTemplate = new DataTemplate(() => {
					var grid = new Grid { Padding = new Thickness(5, 10) };
					grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
					grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

					var image = new Image();
					image.SetBinding(Image.SourceProperty, "IconSource");
					var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
					label.SetBinding(Label.TextProperty, "Title");

					grid.Children.Add(image);
					grid.Children.Add(label, 1, 0);

					return new ViewCell { View = grid };
				}),
				SeparatorVisibility = SeparatorVisibility.None
			};

			//Icon = "slideout.png";
			//Title = "Home";
			//Content = new StackLayout
			//{
			//	Children = { listView }
			//};
		}
    }
}
