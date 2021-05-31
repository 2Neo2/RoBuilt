using System;
using System.Collections.ObjectModel;

namespace RoBuilt.Models
{
    public class MyProgressListModel
    {

        public ObservableCollection<ModelPr> MyProgress { get; set; }


        public MyProgressListModel()
        {
            MyProgress = new ObservableCollection<ModelPr>
            {
                new ModelPr { Name = "Самый пунктуальный", IsDone = "1 / 1" },
                new ModelPr { Name = "Гуру путеществий", IsDone = "0 / 1" },
                new ModelPr { Name = "Клуб за 40", IsDone = "0 / 1" },
                new ModelPr { Name = "Клуб за 20", IsDone = "1 / 1" },
                new ModelPr { Name = "Лучший путешественник сезона", IsDone = "0 / 1" },
                new ModelPr { Name = "Самый дружелюбный", IsDone = "1 / 1" },
                new ModelPr { Name = "Самый общительный", IsDone = "0 / 1" },
                new ModelPr { Name = "Использует приложение больше 1 дня", IsDone = "1 / 1" },
                new ModelPr { Name = "Использует приложение больше 1 недели", IsDone = "1 / 1" },
                new ModelPr { Name = "Использует приложение больше 1 месяца", IsDone = "0 / 1" },
            };
        }
    }
}
