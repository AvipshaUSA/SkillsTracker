using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.VisualBasic.CompilerServices;

namespace SkillsTracker.Controllers
{
   
    public class SkillsController : Controller
    {
      [HttpGet]
       [Route ("/skillstracker")]
            
        public IActionResult Index()
        {
            string html =  "<h1 >Skills Tracker </h1><h2>Coding skills to learn: </h2>" + "<h2> <ol>  <li>C#</li> " + " <br> " + "<li>JavaScript</li> " + " <br> " + "<li>Python</li>";
            return Content(html, "text/html"); 
        }


        

        
      [HttpGet]
      [Route("skillstracker/form")]      // in browser skillstracker/form
        public IActionResult Form()
        {
            string html =  "<form method = 'POST' action = '/skillstracker/form/'>" +
               
                "<p>Date:</p> "+
                "<input type = 'date' name = 'date' /> " +
                
                "<p>C#</p>"+
                "<Select name ='cSharp'><option value ='Making Apps'>Making Apps <option value = 'Learning Basics'>Learning Basics<option value = 'Master Code'>Master Code</option></select>" + " <br>" +
                "<p>JavaScript</p>" +
                "<Select name ='javaScript'><option value ='Making Apps'>Making Apps <option value = 'Learning Basics'>Learning Basics<option value = 'Master Code'>Master Code</option></select>" + " <br>" +
                "<p>Python</p>" +
                "<Select name ='python'><option value ='Making Apps'>Making Apps <option value = 'Learning Basics'>Learning Basics<option value = 'Master Code'>Master Code</option></select>"+ " <br>" +

                 "<input type = 'submit' value= 'submit!'  />" + " <br>" +
              
                "</form>";
      

            return Content(html,"text/html");
        }


       
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            
            // this post method is same for everyone for table() method and form() method


            [HttpPost]
        [Route("skillstracker/form/")]
        [HttpPost]
        [Route("skillstracker/table/")]

        public IActionResult Form( string cSharp, string date , string javaScript, string python)
        {
            string html = "<center>" + " <h2> " + date + " </h2> " +
                " <ol> " +
                " <li> C#: " + cSharp + "</li>" +" <br>" +
                "<li>Javascript: " + javaScript + "</li>" + " <br>" +
                "<li>Python: " + python + "</li>" + " <br>" +
                "</ol>" +"</center>";


            //return Content("<h1><p>Skill Tracker Of " + name+"!!</p></h1>" +"<h2>" + date +"</h2>" +"<p>"+"C#: " + cSharp + "</p>"+ "<p>Javascript: " + javaScript+ "</p>" + "<p>Python: " + python + "</p><br>"  , "text/html");
            return Content(html, "text/html");
        }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        [Route("skillstracker/table/")]  // in address bar    skillstracker/table
        public IActionResult table()
        {
            string html = "<form method = 'POST' action = '/skillstracker/table/'>" +
                "<table border = 2>" +
                "<tr>" +
                "<td>" + "Date: " + "</td>" +
               "<td>"+ "<input type = 'date' name = 'date' /> " + "</td>" +
               "</tr>"+ " <br>" +

               "<tr>" +
                "<td>" + "C#: " + "</td>" +
               "<td>" + "<Select name ='cSharp'><option value ='Making Apps'>Making Apps <option value = 'Learning Basics'>Learning Basics<option value = 'Master Code'>Master Code</option></select>" + " </td>" +
               "</tr>" + " <br>" +

                 "<tr>" +
                "<td>" + "Javascript: " + "</td>" +
               "<td>" + "<Select name ='Javascript'><option value ='Making Apps'>Making Apps <option value = 'Learning Basics'>Learning Basics<option value = 'Master Code'>Master Code</option></select>" + " </td>" +
               "</tr>" + " <br>" +


                "<tr>" +
                "<td>" + "Python: " + "</td>" +
               "<td>" + "<Select name ='Javascript'><option value ='Making Apps'>Making Apps <option value = 'Learning Basics'>Learning Basics<option value = 'Master Code'>Master Code</option></select>" + " </td>" +
               "</tr>" + " <br>" +

                "</table>" +
                 "<input type = 'submit' value= 'submit!'  />" +
                "</form>";

            ;
            return Content(html, "text/html");
        }



    }

}
