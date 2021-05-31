using System;
using System.Collections.ObjectModel;

namespace RoBuilt.Models
{
    public class MyMeetingListModel
    {

        public ObservableCollection<ModelMeeting> MyMeeting { get; set; }


        public MyMeetingListModel()
        {
            MyMeeting = new ObservableCollection<ModelMeeting>();
            
        }
    }
}
