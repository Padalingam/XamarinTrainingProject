﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Helloworld
{
	public partial class MapPage : ContentPage
	{
		public MapPage()
		{
			InitializeComponent();

			var map = new Map(
			MapSpan.FromCenterAndRadius(
					new Position(37, -122), Distance.FromMiles(0.3)))
			{
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			var slider = new Slider(1, 18, 1);
			slider.ValueChanged += (sender, e) =>
			{
				var zoomLevel = e.NewValue; // between 1 and 18
				var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
				map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongdegrees, latlongdegrees));
			};
			var stack = new StackLayout { Spacing = 0 };
			stack.Children.Add(map);
			stack.Children.Add(slider);
			Content = stack;
			var position = new Position(37, -122); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.SavedPin,
				Position = position,
				Label = "custom pin",
				Address = "custom detail info"
			};
			map.Pins.Add(pin);
			map.MapType = MapType.Satellite;
		}
	}
}
