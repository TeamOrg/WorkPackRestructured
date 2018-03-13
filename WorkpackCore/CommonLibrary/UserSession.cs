//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Web;


//namespace CommonLibrary
//{
//    public class UserSession
//    {

//        #region "UserName"
//        public static string Username
//        {
//            get
//            {
//                if (HttpContext.Current.Session["Username"] != null)
//                {
//                    return HttpContext.Current.Session["Username"].ToString();
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            set { HttpContext.Current.Session["Username"] = value; }
//        }
       

       

//        public static string UserID
//        {
//            get
//            {
//                if (HttpContext.Current.Session["UserId"] != null)
//                {
//                    return HttpContext.Current.Session["UserId"].ToString();
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            set { HttpContext.Current.Session["UserId"] = value; }
//        }

//        #endregion

//        #region "ProfileId"
//        public static string ProfileId
//        {
//            get
//            {
//                if (HttpContext.Current.Session["ProfileId"] != null)
//                {
//                    return HttpContext.Current.Session["ProfileId"].ToString();
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            set { HttpContext.Current.Session["ProfileId"] = value; }
//        }
//        #endregion

//        #region "Name"
//        public static string Name
//        {
//            get
//            {
//                if (HttpContext.Current.Session["Name"] != null)
//                {
//                    return HttpContext.Current.Session["Name"].ToString();
//                }
//                else
//                {
//                    return null;
//                }
//            }
//            set { HttpContext.Current.Session["Name"] = value; }
//        }
//        #endregion

       

//    }
//}