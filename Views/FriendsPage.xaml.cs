using System;
using System.Collections.Generic;
using RoBuilt.Models;

using Xamarin.Forms;

namespace RoBuilt.Views
{
    public partial class FriendsPage : ContentPage
    {
        public FriendsPage()
        {
            InitializeComponent();

            BindingContext = new MyFriendsListModel();

        }

        public void ButtonSearch_Clicked(object sender, EventArgs arg)
        {

        }
    }
}
