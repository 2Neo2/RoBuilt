using System;
using System.Collections.Generic;
using RoBuilt.Models;
using Xamarin.Forms;

namespace RoBuilt.Views
{
    public partial class PublicPlaceRatingPapge : ContentPage
    {
        public PublicPlaceRatingPapge()
        {
            InitializeComponent();

            BindingContext = new MyViewListModel();
        }


        async private void Item_Tabbed(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as Model;

            switch (selectedItem.Id)
            {
                case 0:
                    await Navigation.PushAsync(new ContentPage1());
                    break;
                case 1:
                    await Navigation.PushAsync(new ContentPage2());
                    break;
                case 2:
                    await Navigation.PushAsync(new ContentPage3());
                    break;
                case 3:
                    await Navigation.PushAsync(new ContentPage4());
                    break;
                case 4:
                    await Navigation.PushAsync(new ContentPage5());
                    break;
                case 5:
                    await Navigation.PushAsync(new ContentPage6());
                    break;
                case 6:
                    await Navigation.PushAsync(new ContentPage7());
                    break;
                case 7:
                    await Navigation.PushAsync(new ContentPage8());
                    break;
                case 8:
                    await Navigation.PushAsync(new ContentPage9());
                    break;
                case 9:
                    await Navigation.PushAsync(new ContentPage10());
                    break;
                case 10:
                    await Navigation.PushAsync(new ContentPage11());
                    break;
                case 11:
                    await Navigation.PushAsync(new ContentPage12());
                    break;

            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}
