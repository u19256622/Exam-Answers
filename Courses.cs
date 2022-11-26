namespace INF272EXAM20221126.Models
    {
    public class Courses
        {
        public int CourseID { get; set; }
        public string Title { get; set; } = "";
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

        public Courses()
            {
            }

        public Courses(int ID, string title, int cred, int dept)
            {
            CourseID = ID;
            Title = title;
            Credits = cred;
            DepartmentID = dept;
            }

        public virtual string ShowInfo()
            {
            return "The course " + Title;
            }

       public class OnlineCourse : Courses
        {
            public string Url { get; set; }


            public OnlineCourse(string mUrl, int ID, string title, int cred, int dept) : base(ID, title, cred, dept)
            {
                Url = mUrl;
            }
            public override string ShowInfo()
            {
                return "The Course " + Title + " is available at " + Url + " for Online Courses";
            }

        }

       public  class OnsiteCourse : Courses
        {
            public int days { get; set; }
            public string Location { get; set; }

            public OnsiteCourse(int mday, string mLocation, int ID, string title, int cred, int dept) : base(ID, title, cred, dept)
            {
                days = mday;
                Location = mLocation;
            }
            public override string ShowInfo()
            {
                return "The Course " + Title + " is taught on  " + days + " in " + Location;
            }

        }

        // Complete the question for this section BELOW THIS LINE.
        // Do not remove the green line.
        // -------------------------------------------------------
        // -------------------------------------------------------
    }
    }