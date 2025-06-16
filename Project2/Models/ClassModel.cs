using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class ClassModel{
        public string SubjectName { get; set; }
        public string YearAndSection { get; set; }
        public string StartTime { get; set; }
        public string ClassLocation { get; set; }
        public string Status { get; set; }
        public Color BgColor { get; set; }
        public Color TColor { get; set; }

        public ClassModel(string sname, string yas, string st, string cl, ClassStatus status)
        {
            SubjectName = sname;
            YearAndSection = yas;
            StartTime = st;
            ClassLocation = cl;
            Status = Enum.GetName(typeof(ClassStatus), status);
            switch (status)
            {
                case ClassStatus.upcoming:
                    BgColor = Color.FromHex("#ffedd5");
                    TColor = Color.FromHex("#9a3412");
                    break;
                case ClassStatus.completed:
                    BgColor = Color.FromHex("#dcfce7");
                    TColor = Color.FromHex("#166543");
                    break;
                case ClassStatus.ongoing:
                    BgColor = Color.FromHex("#dbeafe");
                    TColor = Color.FromHex("#1e40af");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }
    }

    public enum ClassStatus
    {
        upcoming,
        ongoing,
        completed
    }
}
