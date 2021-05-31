using System;
using System.Collections.Generic;
using RoBuilt.Services;
using Xamarin.Forms;

namespace RoBuilt.Views
{
    public partial class AccountPage : Shell
    {
        public string UserName { get; set; }
        public AccountPage(string username)
        {
            InitializeComponent();

            UserName = username;
        }
    }
}
