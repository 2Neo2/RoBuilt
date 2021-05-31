using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RoBuilt.Models
{
    public class MyViewListModel
    {
        public ObservableCollection<Model> MyData { get; set; }

        public MyViewListModel()
        {
            MyData = new ObservableCollection<Model>() {

                new Model() { Id = 0, PlaceName = "Kremlin", Rating = "Rating: 4,9/5" },
                new Model() { Id = 1, PlaceName = "Bolshoi Theatre", Rating = "Rating: 5/5" },
                new Model() { Id = 2, PlaceName = "GUM", Rating = "Rating: 5/5" },
                new Model() { Id = 3, PlaceName = "Lenin's Mausoleum", Rating = "Rating: 4,8/5" },
                new Model() { Id = 4, PlaceName = "Red Square", Rating = "Rating: 4,9/5" },
                new Model() { Id = 5, PlaceName = "Museum of Cosmonautics", Rating = "Rating: 4,6/5" },
                new Model() { Id = 6, PlaceName = "Moscow Metro", Rating = "Rating: 5/5" },
                new Model() { Id = 7, PlaceName = "Moscow State Integrated Museum-Reserve", Rating = "Rating: 4,4/5" },
                new Model() { Id = 8, PlaceName = "Tretyakov Gallery", Rating = "Rating: 5/5" },
                new Model() { Id = 9, PlaceName = "Arbat Street", Rating = "Rating: 5/5" },
                new Model() { Id = 10, PlaceName = "VDNKh All-Russian Exhibition Centre", Rating = "Rating: 5/5" },
                new Model() { Id = 11, PlaceName = "Gorky Park", Rating = "Rating: 4,5/5" }
            };
        }

    }
}
