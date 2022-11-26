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

        // Complete the question for this section BELOW THIS LINE.
        // Do not remove the green line.
        // -------------------------------------------------------
        // -------------------------------------------------------
        }
    }