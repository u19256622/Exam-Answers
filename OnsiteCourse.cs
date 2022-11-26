using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272EXAM20221126.Models
{
    public class OnsiteCourse: Courses
    {
        public int days { get; set; }
        public string Location { get; set; }

        public OnsiteCourse(int mday, string mLocation, int ID, string title, int cred, int dept ) :base(ID, title, cred, dept)
        {
            days = mday;
            Location = mLocation;
        }
        public override string ShowInfo()
        {
            return "The Course " + Title + " is taught on  "+ days+ " in "+ Location;
        }
    }
}