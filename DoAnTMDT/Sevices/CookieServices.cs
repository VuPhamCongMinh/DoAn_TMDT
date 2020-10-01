using DoAnTMDT.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnTMDT.Sevices
{
    public class CookieServices
    {
        public void AddCookie(HttpContext context, string key, string value)
        {
            CookieOptions cookieOptions = new CookieOptions { Expires = DateTime.Now.AddMinutes(5) };
            context.Response.Cookies.Append(key, value, cookieOptions);
        }
        public string ReadCookie(HttpContext context, string key)
        {
            if (context.Request.Cookies[key] == null)
            {
                return null;
            }
            return context.Request.Cookies[key];
        }
        public void DeleteCookie(HttpContext context, string key)
        {
            context.Response.Cookies.Append(key, "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
        }
    }
}
