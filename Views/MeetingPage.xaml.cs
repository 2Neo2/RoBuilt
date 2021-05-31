using System;
using System.Collections.Generic;
using RoBuilt.Models;
using Xamarin.Forms;

namespace RoBuilt.Views
{
    public partial class MeetingPage : ContentPage
    {
        private MyMeetingListModel meetings = new MyMeetingListModel();
        public MeetingPage()
        {
            InitializeComponent();
            BindingContext = new MyProgressListModel();
        }

        void button_request_Clicked(System.Object sender, System.EventArgs e)
        {
            var dataTime = datePlaceHolder.Text + " " + timePlaceHolder.Text;
            var place = placePlaceHolder.Text;

            placePlaceHolder.Text = "";
            datePlaceHolder.Text = "";
            timePlaceHolder.Text = "";


            meetings.MyMeeting.Add(new ModelMeeting() { DateTime = dataTime, Place= place});
            BindingContext = meetings;
        }
    }
}
