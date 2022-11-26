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
            private string v;

            public string Url { get; set; }


        
            public OnlineCourse(int ID, string title, int cred, int dept, string v) : base(ID, title, cred, dept)
            {
                this.v = v;
            }

            public override string ShowInfo()
            {
                return "The Course " + Title + " is available at " + Url + " for Online Courses";
            }

        }

       public  class OnsiteCourse : Courses
        {
            private string v1;
            private string v2;
            private object p;

            public int days { get; set; }
            public string Location { get; set; }

        
            public OnsiteCourse(int ID, string title, int cred, int dept, string v1, string v2, object p) : base(ID, title, cred, dept)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.p = p;
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