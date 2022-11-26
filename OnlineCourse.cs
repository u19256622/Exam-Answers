using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272EXAM20221126.Models
{
    public class OnlineCourse : Courses
    {
        public string  Url { get; set; }


        public OnlineCourse( string mUrl, int ID, string title, int cred, int dept) : base(ID, title, cred, dept)
        {
            Url = mUrl;
        }
        public override string ShowInfo()
        {
            return "The Course "+Title+" is available at "+ Url+" for Online Courses";
        }
    }
}