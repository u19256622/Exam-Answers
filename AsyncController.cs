using INF272EXAM20221126.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace INF272EXAM20221126.Controllers
    {
    public class AsyncController : Controller
        {
        public SchoolEntities db = new SchoolEntities();

        public ActionResult Async()
            {

              return View();
            }

        // Complete the question for this section BELOW THIS LINE.
        // Do not remove the green line.
        // -------------------------------------------------------
        // -------------------------------------------------------

        public async Task<ActionResult> GetDepartment()
            {
                 return Json(await db.Departments.ToListAsync(), JsonRequestBehavior.AllowGet); 
            }
        }
    }