using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Teju.Models;

namespace Teju.Controllers
{
    public class AccountController : Controller
    {
        public static List<LoginInfo > lstLoginInfo;

     
    
        [HttpGet]
        public IActionResult Login()
        {
    
            return View();


        }

        
        [HttpPost]
        public IActionResult Login(LoginInfo objLoginInfo )
        {
              if (lstLoginInfo == null) 
              {
                lstLoginInfo = new List<LoginInfo> ();
              }
              lstLoginInfo.Add(objLoginInfo);
        
            return RedirectToAction("LoginUserList");
        }
           public IActionResult LoginUserList()

        {
            if (lstLoginInfo== null)
            
            {
                lstLoginInfo= new List<LoginInfo>();
            }
            return View(lstLoginInfo);


        }



    }

 
}

