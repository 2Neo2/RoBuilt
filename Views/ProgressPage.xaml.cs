using System;
using System.Collections.Generic;
using RoBuilt.Models;
using Xamarin.Forms;

namespace RoBuilt.Views
{
    public partial class ProgressPage : ContentPage
    {
        public ProgressPage()
        {
            InitializeComponent();

            BindingContext = new MyProgressListModel();
        }
    }
}
