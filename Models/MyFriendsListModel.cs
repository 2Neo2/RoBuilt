using System;
using System.Collections.ObjectModel;

namespace RoBuilt.Models
{
    public class MyFriendsListModel
    {
        public ObservableCollection<ModelFriend> MyFriend { get; set; }

        public MyFriendsListModel()
        {
            MyFriend = new ObservableCollection<ModelFriend>
            {
                new ModelFriend() { Login = "maandryuschenko@edu.hse.ru", FullName = "Андрющенко Михаил Андреевич"},
                new ModelFriend() { Login = "doroninIvan@edu.hse.ru", FullName = "Доронин Иван Александрович"},
                new ModelFriend() { Login = "kepetrova@edu.hse.ru", FullName = "Петрова Ксения Эдуардовна"},
                new ModelFriend() { Login = "sharipova@edu.hse.ru", FullName = "Шарипов Артур Маратович"},
                new ModelFriend() { Login = "mitkina@edu.hse.ru", FullName = "Миткина Александра Сергеевна"},
                new ModelFriend() { Login = "mitkina@edu.hse.ru", FullName = "Миткина Александра Сергеевна"},
            };
        }
    }
}
