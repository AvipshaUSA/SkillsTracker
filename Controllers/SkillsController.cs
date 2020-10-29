using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic.CompilerServices;

namespace SkillsTracker.Controllers
{
    //[Route("/skillstracker")]
    public class SkillsController : Controller
    {
       [HttpGet]
       [Route ("/skillstracker")]
            
        public IActionResult Index()
        {
            string html = "<h1 >Skills Tracker </h1><h2>Coding skills to learn: </h2>" + "<form method = 'POST' action = '/skillstracker/'>"+ "<h2> <ol>  <li>C#</li> <li>JavaScript</li> <li>Python</li> ";
            return Content(html, "text/html"); 
        }


        

        //[HttpGet("form/")]
       // [HttpPost]
      [HttpGet]
      [Route("skillstracker/form")]
        public IActionResult Form()
        {
            string html =  "<form method = 'POST' action = '/skillstracker/form/'>" +
                "<p>Date:</p> "+
                "<input type = 'date' name = 'date' /> " +
                "<p>Name:</p> "+
                "<input type = 'text' name = 'name'>"+
                "<p>C#</p>"+
                "<Select name ='cSharp'><option value ='1'>Making Apps <option value = '2'>Learning Basics<option value = '3'>Master Code</option></select>" + 
                "<p>JavaScript</p>" +
                "<Select name ='javaScript'><option value ='1'>Making Apps <option value = '2'>Learning Basics<option value = '3'>Master Code</option></select>" +
                "<p>Python</p>" +
                "<Select name ='python'><option value ='1'>Making Apps <option value = '2'>Learning Basics<option value = '3'>Master Code</option></select>"
                + "<input type = 'submit' value= 'submit!'  />" + 
                "</form>";
      

            return Content(html,"text/html");
        }



        //[HttpGet]
        
         [HttpPost]
        [Route("skillstracker/form/")]

        public IActionResult Result(string name, string cSharp, string date , string javaScript, string python)
        {
            if (cSharp == "1")
                {
                cSharp = "Making Apps";
            }
            else if(cSharp == "2")
            {
                cSharp = "Learning Basics";
            }else if (cSharp == "3")
            {
                cSharp = "Master Code";
            }



            if(javaScript == "1")
            {
                javaScript = "Making App";
            }
            else if (javaScript == "2")
            {
                javaScript = "Learning Basics";
            }else if(javaScript == "3")
            {
                javaScript = "Master Code";
            }

      
             if ( python == "1") 
            {
                python = "Making App";

             }
              else if (python == "2")
              {
               
      
                python = "Learning Basics";
              }

               else if (python == "3")
               {
                python = "Master Code";
               }
            //return Content("<h1><p>Skill Tracker Of " + name+"!!</p></h1>" +"<h2>" + date +"</h2>" +"<p>"+"C#: " + cSharp + "</p>"+ "<p>Javascript: " + javaScript+ "</p>" + "<p>Python: " + python + "</p><br>"  , "text/html");
            return Content("<h1><p>Skill Tracker Of " + name + "!!</p></h1>" + "<h2>" + date + "</h2>" + "<ol>" + "<li>C#: " + cSharp + "</li>" + "<li>Javascript: " + javaScript + "</li>" + "<li>Python: " + python + "</li></ol>", "text/html");
        }
    }
    
}
