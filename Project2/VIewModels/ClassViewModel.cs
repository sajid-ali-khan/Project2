using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2.Models;

namespace Project2.VIewModels
{
    class ClassViewModel
    {
        public ICollection<ClassModel> Classes { get; set; }
        public ClassViewModel()
        {
            Classes =
            [
                new ClassModel("Computer Science", "3rd Year - A", DateTime.Now.AddHours(1).ToString("t"), "CS-101", ClassStatus.upcoming),
                new ClassModel("Data Structures", "2nd Year - B", DateTime.Now.AddHours(2).ToString("t"), "CS-102", ClassStatus.completed),
                new ClassModel("Web Development", "3rd Year - A", DateTime.Now.AddHours(3).ToString("t"), "CS-103", ClassStatus.ongoing),
                new ClassModel("Database Systems", "4th Year - A", DateTime.Now.AddHours(4).ToString("t"), "CS-104", ClassStatus.upcoming),
            ];
        }
    }
}
