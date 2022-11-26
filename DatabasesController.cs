using INF272EXAM20221126.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace INF272EXAM20221126.Controllers
    {
    public class DatabasesController : Controller
        {
        protected SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

        public DatabasesController()
            {
            stringBuilder["Data Source"] = ".";
            stringBuilder["Integrated Security"] = "true";
            stringBuilder["Initial Catalog"] = "School";
            }

        public ActionResult Databases()
            {
            List<PersonVM> ps = GetPeople();
            return View(ps);
            }

        public List<PersonVM> GetPeople()
            {
            List<PersonVM> persons = new List<PersonVM>();

            // Complete the question for this section BELOW THIS LINE.
            // Do not remove the green line.
            // -------------------------------------------------------
            // -------------------------------------------------------

            SqlConnection con = new SqlConnection(stringBuilder.ToString());

            SqlCommand cmd = new SqlCommand("SELECT * FROM Person", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var person = new PersonVM();

                person.FirstLetter = (rdr["FirstName"]).ToString().Substring(0,1);
                person.NameLength = (rdr["FirstName"].ToString()).Length;
                person.person = new Person();
                person.person.FirstName = rdr["FirstName"].ToString();
                person.person.LastName = rdr["LastName"].ToString();
                person.person.PersonID = Convert.ToInt32(rdr["PersonID"].ToString());
                person.person.HireDate = Convert.ToDateTime(rdr["HireDate"].ToString());
                person.person.EnrollmentDate = Convert.ToDateTime(rdr["EnrollmentDate"].ToString());
                person.person.Discriminator = rdr["Discriminator"].ToString();

                persons.Add(person);
            }
            return persons;
            }
        }
    }