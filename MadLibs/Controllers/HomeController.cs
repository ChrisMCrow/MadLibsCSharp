using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/Result")]
        public ActionResult Result()
        {
            MadLib newMadLib = new MadLib();
            newMadLib.SetAdjective1(Request.Query["Adjective1"]);
            newMadLib.SetNoun1(Request.Query["Noun1"]);
            newMadLib.SetNumber(Request.Query["Number"]);
            newMadLib.SetNoun2(Request.Query["Noun2"]);
            newMadLib.SetAdjective2(Request.Query["Adjective2"]);
            newMadLib.SetVerb(Request.Query["Verb"]);
            newMadLib.SetNoun3(Request.Query["Noun3"]);
            newMadLib.SetBodyPart(Request.Query["BodyPart"]);
            newMadLib.SetAdjective3(Request.Query["Adjective3"]);
            return View(newMadLib);
        }
    }
}
