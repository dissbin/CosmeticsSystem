using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Web;
using System.Web.UI;

namespace Conris.Utility
{
    public class AuthenHelper
    {

        public static void CreateTicket(string userName)
        {
            FormsAuthentication.SetAuthCookie(userName, false);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName">用户标识</param>
        /// <param name="userData">用户数据</param>
        /// <param name="stayLogin">是否记住</param>
        /// <param name="expireTime">过期时间</param>
        /// <param name="cookiePath">路径</param>
        public static void CreateTicket(string userName, string userData, bool stayLogin, DateTime expireTime, string cookiePath)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                 1,
                 userName,
                 DateTime.Now,
                 expireTime,
                 stayLogin,
                 userData,
                 cookiePath == "" ? FormsAuthentication.FormsCookiePath : cookiePath);

            string encryptedTicket = FormsAuthentication.Encrypt(ticket);
            HttpCookie authCookie = new HttpCookie(
                FormsAuthentication.FormsCookieName, encryptedTicket);
            if (ticket.IsPersistent)
                authCookie.Expires = ticket.Expiration;
            HttpContext.Current.Response.Cookies.Add(authCookie);
        }

        public static string GetLoginUserName()
        {
            string userName = "";
            if (HttpContext.Current.User.Identity.IsAuthenticated)
                userName = HttpContext.Current.User.Identity.Name;
            return userName;
        }

        public static string GetLoginUserData()
        {
            string userData = "";
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                FormsIdentity formsIdentity = HttpContext.Current.User.Identity as FormsIdentity;
                userData = formsIdentity.Ticket.UserData;
            }
            return userData;
        }

        public static bool CheckLogin()
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }

        public static void Logout()
        {
            FormsAuthentication.SignOut();//从浏览器删除 Forms 身份验证票证。
        }
    }
}
