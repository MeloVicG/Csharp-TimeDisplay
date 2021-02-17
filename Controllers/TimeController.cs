using System;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public ViewResult Time()
        {

            ViewBag.CurrentTime = DateTime.Now;


            return View();
        }
    }
}