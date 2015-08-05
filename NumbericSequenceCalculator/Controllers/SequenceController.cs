using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using NumbericSequenceCalculator.Models;

namespace NumbericSequenceCalculator.Controllers
{
    public class SequenceController : Controller
    {
        // GET: Sequence
        [AllowAnonymous]
        public ActionResult Sequence()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Sequence(NumbericSequence model)
        {
            // var inputNumberValue = Request["inputNumberValue"];
            if (ModelState.IsValid)
            {
                List<string> result = new List<string>();

                model = new NumbericSequence(model.CurrentNumber);
                result = null;

                if (Request.Form["Sequence"] != null)
                {
                    result = model.GetSequence();
                }

                if (Request.Form["OddSequence"] != null)
                {
                    result = model.GetOddSequence();
                }

                if (Request.Form["EvenSequence"] != null)
                {
                    result = model.GetEvenSequence();
                }

                if (Request.Form["CEZSequence"] != null)
                {
                    result = model.GetCEZSequence();
                }

                if (Request.Form["FibonacciSequence"] != null)
                {
                    result = model.GetFibonacciSequence();
                }
                model.SequenceResult = result;
            }
               
               return View(model);
        }
    }
}