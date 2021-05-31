using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace RoBuilt.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            Pin pinMoscow = new Pin()
            {
                Type = PinType.Place,
                Label = "Moscow",
                Address = "Moscow, Russia",
                Position = new Position(55.76351496773763, 37.61066653201168)

            };
            map.Pins.Add(pinMoscow);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pinMoscow.Position, Distance.FromMeters(5000)));
        }

        void button_Search_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}
