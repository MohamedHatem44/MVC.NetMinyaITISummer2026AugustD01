using Microsoft.AspNetCore.Mvc;

namespace MVCDemoD01.Controllers
{
    public class TestController : Controller
    {
        /*------------------------------------------------------------------*/
        // Actions
        //public IActionResult Index()
        //{
        //    return View();
        //}
        /*------------------------------------------------------------------*/
        // Actions Rules
        // 1- Actions must be public methods - Can't be private or protected
        // 2- Actions Can't be static methods
        // 3- Actions Can't be overloaded methods - Can't have multiple methods with the same name
        /*------------------------------------------------------------------*/
        // Action
        // Controller/Action
        // https://localhost:7031/Test/ShowHello1
        public string ShowHello1()
        {
            return "Hello 1 from TestController";
        }
        /*------------------------------------------------------------------*/
        //// No Overloading Allowed for Actions
        //public string ShowHello1(int id)
        //{
        //    return $"Hello 1 from TestController: {id}";
        //}
        /*------------------------------------------------------------------*/
        public ContentResult ShowHello2()
        {
            // Decalre Object of ContentResult
            ContentResult contentResult = new ContentResult();

            // Set Return
            contentResult.Content = "Hello 2 from TestController";

            // Return
            return contentResult;
        }
        /*------------------------------------------------------------------*/
        public JsonResult ShowHello3()
        {
            // Decalre Object of JsonResult
            JsonResult jsonResult = new JsonResult(new { Message = "Hello 3 from TestController" });

            // Return
            return jsonResult;
        }
        /*------------------------------------------------------------------*/
        public ViewResult ShowHello4()
        {
            // Decalre Object of ViewResult
            ViewResult viewResult = new ViewResult();

            // Set Return
            viewResult.ViewName = "ShowHello4";

            // Return
            return viewResult;
        }
        /*------------------------------------------------------------------*/
        public IActionResult ShowHello5(int id)
        {
            if (id % 2 == 0)
            {
                // Decalre Object of ContentResult
                ContentResult contentResult = new ContentResult();

                // Set Return
                contentResult.Content = "Hello 2 from TestController";

                // Return
                return contentResult;
            }
            else
            {
                // Decalre Object of ViewResult
                ViewResult viewResult = new ViewResult();

                // Set Return
                viewResult.ViewName = "ShowHello4";

                // Return
                return viewResult;
            }
        }
        /*------------------------------------------------------------------*/
        public ViewResult ShowHello6()
        {
            return View("ShowHello6");
        }
        /*------------------------------------------------------------------*/
        public IActionResult ShowHello7()
        {
            // Best Practice
            // Return View With Action Name Same as Method Name
            return View(); // This Will Return ShowHello7.cshtml View
        }
        /*------------------------------------------------------------------*/
        // Types of Action Results (Return)
        // 1- Content "String"            => ContentResult
        // 2- View "ShowHello7.cshtml"    => ViewResult
        // 3- JavaScript                  => JavaScriptResult
        // 4- Json                        => JsonResult
        // 5- File                        => FileResult
        // 6- Redirect                    => RedirectResult
        // 7- Not Found                   => NotFoundResult
        /*------------------------------------------------------------------*/
        public IActionResult ShowHello8()
        {
            // Best Practice
            // Return View With Action Name Same as Method Name
            return View(); // This Will Return ShowHello7.cshtml View
        }
        /*------------------------------------------------------------------*/
    }
}