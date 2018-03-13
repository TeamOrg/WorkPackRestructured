using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Text;
using System.Reflection.Emit;

using System.Linq;
using System.Net;
using System.Xml;
using System.Threading;
using System.Reflection;
using System.Security.Principal;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

using System.Threading.Tasks;
using System.Net.Mail;
using DomainModelLibrary;
//using ActiveUp.Net.Mail;


namespace CommonLibrary
{
    public static class GeneralFuntions
    {

        //        #region "Function"
        //        public static void Message(string[] positionArray, string Status)
        //        {
        //            switch (Status.Split('-')[1])
        //            {
        //                case "A":
        //                    Common.GeneralFuntions.ShowMessage("S", "", MessageConstants.Added, 200, positionArray);
        //                    break;
        //                case "U":
        //                    Common.GeneralFuntions.ShowMessage("S", "", MessageConstants.Updated, 200, positionArray);
        //                    break;
        //                case "D":
        //                    Common.GeneralFuntions.ShowMessage("S", "", MessageConstants.Deleted, 200, positionArray);
        //                    break;
        //                case "E":
        //                    Common.GeneralFuntions.ShowMessage("E", "", MessageConstants.errorMsg, 200, positionArray);
        //                    break;
        //                case "R":
        //                    Common.GeneralFuntions.ShowMessage("E", "", MessageConstants.errorMsg, 200, positionArray);
        //                    break;
        //            }
        //        }


        //        public static List<ExuserMapping> GetExuserMapping()
        //        {


        //            List<ExuserMapping> lst = new List<ExuserMapping>();
        //            ExuserMapping ex = new ExuserMapping();
        //            ex.GridColname = "Name";
        //            ex.TableColname = "Name";
        //            lst.Add(ex);
        //            ex = new ExuserMapping();
        //            ex.GridColname = "Company";
        //            ex.TableColname = "CompanyName";
        //            lst.Add(ex);
        //            ex = new ExuserMapping();
        //            ex.GridColname = "Email Address";
        //            ex.TableColname = "ExUser1";
        //            lst.Add(ex);
        //            ex = new ExuserMapping();
        //            ex.GridColname = "Phone No.";
        //            ex.TableColname = "PhoneNo";
        //            lst.Add(ex);
        //            ex = new ExuserMapping();
        //            ex.GridColname = "Designation";
        //            ex.TableColname = "Designation";
        //            lst.Add(ex);

        //            ex = new ExuserMapping();
        //            ex.GridColname = "Role";
        //            ex.TableColname = "Role";
        //            lst.Add(ex);

        //            ex = new ExuserMapping();
        //            ex.GridColname = "Location";
        //            ex.TableColname = "Location";
        //            lst.Add(ex);

        //            return lst;

        //        }

        //        public static string ChangeLabelForClient(string ClientName)
        //        {
        //            String FieldName = String.Empty;
        //            switch (ClientName)
        //            {
        //                case "PETRO":
        //                    FieldName = "Client Asset";
        //                    break;
        //                case "AMAZO":
        //                    FieldName = "Project Group";
        //                    break;

        //            }
        //            return FieldName = "Project Group";
        //        }
        //        public static void HideShowLabelControls(string ClientName, System.Web.UI.WebControls.Label lbl)
        //        {

        //            switch (ClientName)
        //            {
        //                case "PETRO":
        //                    lbl.Visible = true;
        //                    break;
        //                case "AMAZO":
        //                    lbl.Visible = false; ;
        //                    break;

        //            }

        //        }

        //        public static void HideShowdropdownControls(string ClientName, System.Web.UI.WebControls.DropDownList ddl)
        //        {
        //            switch (ClientName)
        //            {
        //                case "PETRO":
        //                    ddl.Visible = true;
        //                    break;
        //                case "AMAZO":
        //                    ddl.Visible = false; ;
        //                    break;

        //            }

        //        }

        //        public static void HideShowButtonControls(string ClientName, System.Web.UI.WebControls.Button btn)
        //        {
        //            switch (ClientName)
        //            {
        //                case "PETRO":
        //                    btn.Visible = true;
        //                    break;
        //                case "AMAZO":
        //                    btn.Visible = false; ;
        //                    break;

        //            }

        //        }



        //public static string GetEnumDescription(Enum value)
        //{
        //    FieldInfo fi = value.GetType().GetField(value.ToString());

        //    DescriptionAttribute[] attributes =
        //        (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

        //    if (attributes != null && attributes.Length > 0)
        //        return attributes[0].Description;
        //    else
        //        return value.ToString();
        //}

        //public static void ShowMessage(string type, string title, string Message, int BoxWidth, string[] positionArray, string AnotherScript = "")
        //{
        //    string icon;
        //    string MType;
        //    if (positionArray.Length != 2)
        //    {

        //        positionArray = ("683,170").Split(',');
        //    }
        //    else if (positionArray.Length == 2)
        //    {
        //        if (positionArray[0] == "undefined" || positionArray[0] == string.Empty)
        //            positionArray[0] = "683";
        //        if (positionArray[1] == "undefined" || positionArray[1] == string.Empty)
        //            positionArray[1] = "170";
        //    }

        //    switch (type.ToUpper())
        //    {
        //        case "S":
        //            icon = "picon icon16 iconic-icon-check-alt white";
        //            MType = "success";
        //            break;
        //        case "E":
        //            icon = "picon icon24 typ-icon-cancel white";
        //            MType = "error";
        //            break;
        //        default:
        //            icon = "picon icon16 brocco-icon-info white";
        //            MType = "info";
        //            break;
        //    }
        //    StringBuilder sb = new StringBuilder();
        //    if (AnotherScript != "")
        //    {
        //        sb.Append("<script type='text/javascript'>" + AnotherScript + "</script>");
        //    }
        //    sb.Append("<script type='text/javascript' src='plugins/misc/pnotify/jquery.pnotify.min.js'></script><script language='javascript'>$.pnotify({");
        //    sb.Append(" type: '" + MType + "',");
        //    sb.Append("title:'" + title + "',");
        //    sb.Append("text:'" + Message + "',");
        //    sb.Append("icon:'" + icon + "',");
        //    //sb.Append("width:'" + BoxWidth + "px',");
        //    if (type.ToUpper() == "S")
        //        sb.Append("delay:1000,");
        //    sb.Append("width:'" + (((Message.Length > 100 ? 50 : Message.Length) * 8) + (80)) + "px',");
        //    sb.Append("DLeft:" + Convert.ToInt32(positionArray[0]) + ",");
        //    sb.Append("DTop:" + Convert.ToInt32(positionArray[1]) + ",");


        //    sb.Append("opacity: 0.95,dynamic:true, history: false, sticker: true });</script>");
        //    var http = System.Web.HttpContext.Current;
        //    if ((http != null))
        //    {
        //        var page1 = http.CurrentHandler as System.Web.UI.Page;
        //        if (page1 != null)
        //        {
        //            var scriptManager = System.Web.UI.ScriptManager.GetCurrent(page1);
        //        }
        //        ScriptManager.RegisterStartupScript(page1, page1.GetType(), "", sb.ToString(), false);
        //    }
        //}

        //        public static void ShowMessageCustom(string type, string title, string Message, int BoxWidth, string[] positionArray, string AnotherScript = "")
        //        {
        //            string icon;
        //            string MType;
        //            if (positionArray.Length != 2)
        //            {

        //                positionArray = ("683,170").Split(',');
        //            }
        //            else if (positionArray.Length == 2)
        //            {
        //                if (positionArray[0] == "undefined" || positionArray[0] == string.Empty)
        //                    positionArray[0] = "683";
        //                if (positionArray[1] == "undefined" || positionArray[1] == string.Empty)
        //                    positionArray[1] = "170";
        //            }

        //            switch (type.ToUpper())
        //            {
        //                case "S":
        //                    icon = "picon icon16 iconic-icon-check-alt white";
        //                    MType = "success";
        //                    break;
        //                case "E":
        //                    icon = "picon icon24 typ-icon-cancel white";
        //                    MType = "error";
        //                    break;
        //                default:
        //                    icon = "picon icon16 brocco-icon-info white";
        //                    MType = "info";
        //                    break;
        //            }
        //            StringBuilder sb = new StringBuilder();
        //            if (AnotherScript != "")
        //            {
        //                sb.Append("<script type='text/javascript'>" + AnotherScript + "</script>");
        //            }
        //            sb.Append("<script type='text/javascript' src='plugins/misc/pnotify/jquery.pnotify.min.js'></script><script language='javascript'>$.pnotify({");
        //            sb.Append(" type: '" + MType + "',");
        //            sb.Append("title:'" + title + "',");
        //            sb.Append("text:'" + Message + "',");
        //            sb.Append("icon:'" + icon + "',");
        //            sb.Append("width:'" + BoxWidth + "px',");
        //            if (type.ToUpper() == "S")
        //                sb.Append("delay:3000,");
        //            //sb.Append("width:'" + (((Message.Length > 100 ? 50 : Message.Length) * 8) + (80)) + "px',");
        //            sb.Append("DLeft:" + Convert.ToInt32(positionArray[0]) + ",");
        //            sb.Append("DTop:" + Convert.ToInt32(positionArray[1]) + ",");


        //            sb.Append("opacity: 0.95,dynamic:true, history: false, sticker: true });</script>");
        //            var http = System.Web.HttpContext.Current;
        //            if ((http != null))
        //            {
        //                var page1 = http.CurrentHandler as System.Web.UI.Page;
        //                if (page1 != null)
        //                {
        //                    var scriptManager = System.Web.UI.ScriptManager.GetCurrent(page1);
        //                }
        //                ScriptManager.RegisterStartupScript(page1, page1.GetType(), "", sb.ToString(), false);
        //            }
        //        }





        //        public static void ExportTOExcel(DataTable dtList, string Title, string FileName)
        //        {
        //            try
        //            {
        //                DataTable dt = dtList;

        //                if (dt.Rows.Count > 0)
        //                {

        //                    GridView gv = new GridView();
        //                    HttpContext.Current.Response.Clear();
        //                    HttpContext.Current.Response.Buffer = true;
        //                    HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + FileName + ".xls");
        //                    HttpContext.Current.Response.Charset = "";
        //                    HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
        //                    StringWriter sw = new StringWriter();
        //                    string filters = "<div><table border='1'><tr><td colspan='" + dtList.Columns.Count + "' valign='middle' align='center'><h3>" + Title + "</h3></td></tr></table></div></br>";
        //                    sw.Write(filters);
        //                    HtmlTextWriter hw = new HtmlTextWriter(sw);
        //                    gv.AllowPaging = false;
        //                    gv.AllowSorting = false;
        //                    gv.ShowFooter = false;

        //                    gv.AutoGenerateColumns = true;
        //                    gv.DataSource = dt;
        //                    gv.DataBind();

        //                    gv.HeaderRow.Style.Add("background-color", "#FFFFFF");
        //                    //Applying stlye to gridview header cells
        //                    for (int i = 0; i < gv.HeaderRow.Cells.Count; i++)
        //                    {
        //                        gv.HeaderRow.Cells[i].Style.Add("background-color", "#aaaaaa");
        //                    }

        //                    gv.RenderControl(hw);
        //                    //style to format numbers to string
        //                    string style = @"<style> .textmode { mso-number-format:\@; } </style>";

        //                    HttpContext.Current.Response.Write(style);
        //                    HttpContext.Current.Response.Output.Write(sw.ToString().Replace('_', ' '));
        //                    HttpContext.Current.Response.Flush();
        //                    HttpContext.Current.Response.End();

        //                    //  HttpContext.Current.ApplicationInstance.CompleteRequest();
        //                    gv.Dispose();
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);

        //            }
        //            finally
        //            {
        //                HttpContext.Current.Response.End();
        //            }
        //        }

        //        public static void AddNoCache()
        //        {
        //            System.Web.HttpContext.Current.Response.Cache.SetNoStore();
        //            System.Web.HttpContext.Current.Response.AppendHeader("Pragma", "no-cache");
        //            System.Web.HttpContext.Current.Response.Expires = 0;
        //        }

        //        public static void FillDropDownList(DropDownList ddl, DataTable dt, bool blnSelect, string sTextField, string sValueField, string selectedvalue = "0")
        //        {
        //            if (dt != null && dt.Rows.Count != 0)
        //            {
        //                ddl.DataSource = dt;
        //                ddl.DataValueField = dt.Columns[sValueField].ToString();
        //                ddl.DataTextField = dt.Columns[sTextField].ToString();
        //                ddl.DataBind();
        //                if (blnSelect)
        //                {
        //                    ddl.Items.Insert(0, new ListItem("Select", "0"));
        //                    ddl.SelectedValue = selectedvalue;
        //                }
        //            }
        //            else
        //            {
        //                ddl.Items.Clear();
        //                if (blnSelect)
        //                {
        //                    ddl.Items.Add(new ListItem("Select", "0"));
        //                    ddl.SelectedValue = selectedvalue;
        //                }
        //            }
        //        }
        //        public static void FillDropDown(DropDownList ddl, List<object> dt, bool blnSelect, string sTextField, string sValueField, string selectedvalue = "0", string removeValue = "0")
        //        {
        //            if (dt.Count != 0)
        //            {
        //                ddl.Items.Clear();
        //                ddl.DataSource = dt;
        //                ddl.DataValueField = sValueField;
        //                ddl.DataTextField = sTextField;
        //                ddl.DataBind();
        //                if (blnSelect)
        //                {
        //                    ddl.Items.Insert(0, new ListItem("Select", "0"));
        //                    ddl.SelectedValue = selectedvalue;
        //                }
        //            }
        //            else
        //            {
        //                ddl.Items.Clear();
        //                if (blnSelect)
        //                {
        //                    ddl.DataSource = dt;
        //                    ddl.DataValueField = sValueField;
        //                    ddl.DataTextField = sTextField;
        //                    ddl.DataBind();
        //                    ddl.Items.Add(new ListItem("Select", "0"));
        //                    ddl.SelectedValue = selectedvalue;

        //                }
        //            }
        //        }

        //        public static void FillDropDownWithAllOption(DropDownList ddl, List<object> dt, bool blnSelect, string sTextField, string sValueField, string selectedvalue = "0")
        //        {
        //            if (dt.Count != 0)
        //            {
        //                ddl.DataSource = dt;
        //                ddl.DataValueField = sValueField;
        //                ddl.DataTextField = sTextField;
        //                ddl.DataBind();
        //                if (blnSelect)
        //                {
        //                    ddl.Items.Insert(0, new ListItem("All", "0"));
        //                    ddl.SelectedValue = selectedvalue;
        //                }
        //            }
        //            else
        //            {
        //                ddl.Items.Clear();
        //                if (blnSelect)
        //                {
        //                    ddl.Items.Add(new ListItem("All", "0"));
        //                    ddl.SelectedValue = selectedvalue;
        //                }
        //            }
        //        }




        //        public static void CreateDataTableStructure(ref DataTable dt, string[] param)
        //        {
        //            for (int i = 0; i < param.GetLength(1); i++)
        //            {
        //                dt.Columns.Add(param[1]);
        //            }
        //        }
        public static string GenerateRandomPassword(String prefix, int passwordLength)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string randomPassword = string.Empty;
            String fixedPassword = string.Empty;
            Random random = new Random();
            if (prefix.Length >= 3)
                fixedPassword = prefix.Substring(0, 3) + "@" + random.Next(9);
            else
                fixedPassword = prefix + "@" + random.Next(9);
            if (passwordLength > fixedPassword.Length)
            {
                for (int i = 0; i < passwordLength - fixedPassword.Length; i++)
                {
                    int x = random.Next(1, chars.Length);
                    //Don't Allow Repetation of Characters
                    if (!randomPassword.Contains(chars.GetValue(x).ToString()))
                        randomPassword += chars.GetValue(x);
                    else
                        i--;
                }
            }
            return fixedPassword + randomPassword;
        }

        public static string GenerateRandomUserCode(String prefix, int userCodeLength)
        {
            char[] chars = "12345678910".ToCharArray();
            string randomUserCode = string.Empty;
            String fixedUsercode = "";
            Random random = new Random();
            if (prefix.Length >= 4)
                fixedUsercode = prefix.Substring(0, 4);
            else
                fixedUsercode = prefix;
            if (userCodeLength > fixedUsercode.Length)
            {
                for (int i = 0; i < userCodeLength - fixedUsercode.Length; i++)
                {
                    int x = random.Next(1, chars.Length);
                    //Don't Allow Repetation of Characters
                    if (!randomUserCode.Contains(chars.GetValue(x).ToString()))
                        randomUserCode += chars.GetValue(x);
                    else
                        i--;
                }
            }
            return fixedUsercode + randomUserCode;
        }

        //        /// <summary>
        //        /// Converts the sort direction to SQL.
        //        /// </summary>
        //        /// <param name="sortDirection">The sort direction.</param>
        //        /// <returns></returns>
        //        public static string ConvertSortDirectionToSql(SortDirection sortDirection)
        //        {
        //            string newSortDirection = String.Empty;
        //            String existingSortDirection = Convert.ToString(HttpContext.Current.Session["SortDirection"]);
        //            switch (sortDirection)
        //            {
        //                case SortDirection.Ascending:
        //                    newSortDirection = "ASC";
        //                    break;

        //                case SortDirection.Descending:
        //                    newSortDirection = "DESC";
        //                    break;
        //            }
        //            if (existingSortDirection == String.Empty)
        //            {
        //                HttpContext.Current.Session["SortDirection"] = newSortDirection;
        //            }
        //            else
        //            {
        //                newSortDirection = (existingSortDirection == "ASC" ? "DESC" : "ASC");
        //                HttpContext.Current.Session["SortDirection"] = (existingSortDirection == "ASC" ? "DESC" : "ASC");
        //            }
        //            return newSortDirection;
        //        }
        //        /// <summary>
        //        /// Decrypts the specified text.
        //        /// </summary>
        //        /// <param name="text">The text.</param>
        //        /// <returns></returns>
        //        public static String Decrypt(String text)
        //        {
        //            //return SymCrypto.Instance.Decrypt(text, "!@12qw ¦");
        //            return AESEncryption.Decrypt(text, "!@12qw ¦");
        //        }

        //        /// <summary>
        //        /// Encrypts the specified text.
        //        /// </summary>
        //        /// <param name="text">The text.</param>
        ////        /// <returns></returns>
        public static String Encrypt(String text)
        {
            //return SymCrypto.Instance.Encrypt(text, "!@12qw ¦");
            return AESEncryption.Encrypt(text, "!@12qw ¦");
        }

        //public static bool IsBaseString(string value)
        //{
        //    if (string.IsNullOrEmpty(value))
        //    {
        //        return false;
        //    }
        //    return Regex.IsMatch(value, "^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{4}|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)$");

        //}
        ///// <summary>
        ///// Decrypts the specified text.
        ///// </summary>
        ///// <param name="text">The text.</param>
        ///// <returns></returns>
        public static String Decrypt(String text)
        {
            //return SymCrypto.Instance.Decrypt(text, "!@12qw ¦");
            return AESEncryption.Decrypt(text, "!@12qw ¦");
        }

        ///// <summary>
        ///// Encrypts the specified text.
        ///// </summary>
        ///// <param name="text">The text.</param>
        ///// <returns></returns>
        //public static String Encrypt(String text)
        //{
        //    //return SymCrypto.Instance.Encrypt(text, "!@12qw ¦");
        //    return AESEncryption.Encrypt(text, "!@12qw ¦");
        //}
        /// <summary>
        /// Decrypts the string.
        /// </summary>
        /// <param name="encryptedString">The encrypted string.</param>
        /// <returns></returns>
        //public static String DecryptString(String encryptedString)
        //{
        //    String[] arrstr;
        //    //if (encryptedString.EndsWith("=") || encryptedString.Contains("+"))
        //    //{
        //    try
        //    {
        //        if (IsBaseString(encryptedString))
        //        {
        //            encryptedString = Decrypt(encryptedString);
        //        }
        //        else
        //        {
        //            if (encryptedString.Contains("-"))
        //            {
        //                try
        //                {
        //                    String[] arrEncryptedOne = encryptedString.Split('-');
        //                    encryptedString = arrEncryptedOne[0] + '-' + Decrypt(arrEncryptedOne[1]);
        //                }
        //                catch
        //                {

        //                }
        //            }
        //            else
        //            {
        //                arrstr = encryptedString.Split(' ');
        //                encryptedString = "";
        //                for (int i = 0; i < arrstr.Length; i++)
        //                {
        //                    //if (arrstr[i].EndsWith("=") || arrstr[i].Contains("+"))
        //                    //{
        //                    encryptedString += Decrypt(arrstr[i]) + (i == (arrstr.Length - 1) ? "" : " ");
        //                    //}
        //                }
        //            }
        //        }

        //    }
        //    catch
        //    {
        //        if (encryptedString.Contains("-"))
        //        {
        //            try
        //            {
        //                String[] arrEncryptedOne = encryptedString.Split('-');
        //                encryptedString = arrEncryptedOne[0] + '-' + Decrypt(arrEncryptedOne[1]);
        //            }
        //            catch
        //            {

        //            }
        //        }
        //        else
        //        {
        //            arrstr = encryptedString.Split(' ');
        //            encryptedString = "";
        //            for (int i = 0; i < arrstr.Length; i++)
        //            {
        //                //if (arrstr[i].EndsWith("=") || arrstr[i].Contains("+"))
        //                //{
        //                encryptedString += Decrypt(arrstr[i]) + (i == (arrstr.Length - 1) ? "" : " ");
        //                //}
        //            }
        //        }
        //    }
        //    //}
        //    return encryptedString;
        //}





        /// <summary>
        /// Enum for E-mailType
        /// </summary>
        public enum EmailFor
        {
            Other,
            ChangeRequest,
            ClientFeedback,
            NewClientInquiry,
            Error,
            OrderConfirmation,
        }
        //        /// <summary>
        //        /// Sends the emails with authenticate.
        //        /// </summary>
        //        /// <param name="query">The query.</param>
        //        /// <param name="message">The message.</param>
        //        /// <param name="emailFor">The email for.</param>
        public static Boolean SendEmailsWithAuthenticate(MailMessage message, EmailFor emailFor, ConfigFile dtEmailConfig, User dtAdminData)
        {
            bool sent = false;
            try
            {

                String UserEmailID = Decrypt(dtAdminData.EmailId);
                String adminEmailPerson = Convert.ToString(dtEmailConfig.SiteAdminUserCode);
                String adminEmailID = "";
                String smtpClientHost = "";
                String smtpUserID = "";
                String smtpPassword = "";

                //if ((dtAdminData.EmailPassword != "" && dtAdminData.EmailPassword != null) && (HttpContext.Current.Session["CompanySMTPHost"] != null && HttpContext.Current.Session["CompanySMTPHost"] != ""))
                //{
                //    adminEmailID = Convert.ToString(dtAdminData.EmailID1);
                //    smtpClientHost = Convert.ToString(HttpContext.Current.Session["CompanySMTPHost"]);
                //    smtpUserID = Convert.ToString(dtAdminData.EmailID1);
                //    smtpPassword = DecryptString(Convert.ToString(dtAdminData.EmailPassword));
                //}
                //else
                //{
                    adminEmailID = dtEmailConfig.SMTPUserid;
                    smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);
                    smtpUserID = Convert.ToString(dtEmailConfig.SMTPUserid);
                    smtpPassword = Decrypt(Convert.ToString(dtEmailConfig.SMTPPassword));
                // }

                Boolean sslEnabled = Convert.ToBoolean(dtEmailConfig.SSLEnabled);
                if (adminEmailID.Length == 0 || smtpClientHost.Length == 0 || smtpUserID.Length == 0)
                {
                    return false;
                }
                message.IsBodyHtml = true;
                message.Body = message.Body.Replace("#EmailBy#", adminEmailPerson);
                System.Net.Mail.MailAddress senderID = new System.Net.Mail.MailAddress(adminEmailID, UserEmailID);
                message.Sender = senderID;
                // Delivery notifications
                
                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                switch (emailFor)
                {
                    case EmailFor.Other:
                        message.From = senderID;
                        break;

                }
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                SmtpClient client = new SmtpClient(smtpClientHost);
                client.Credentials = new System.Net.NetworkCredential(smtpUserID, smtpPassword);
                client.EnableSsl = sslEnabled;
                client.Send(message);
                sent = true;

            }
            catch (Exception ex)
            {
                // CCLib.Logger.ErrorException("SendEmailsWithAuthenticate", ex);
                //bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
                sent = false;
            }
            return sent;
        }

        //        public static Boolean SendEmailsCampaign(User Sender, string Recipient, EmailCampaign emailcampaign)
        //        {
        //            bool sent = false;
        //            try
        //            {
        //                MailMessage message = new MailMessage();
        //                message.Body = emailcampaign.CampaignMessage;
        //                message.Subject = emailcampaign.CampaignSubject;
        //                String SendName = Convert.ToString(Sender.FirstName) + " " + Convert.ToString(Sender.LastName);//set user name  of sender
        //                String adminEmailID = Sender.EmailID1; ////set emailid  of sender
        //                String smtpClientHost = Convert.ToString(Sender.SMTPHost);
        //                String smtpUserID = Convert.ToString(Sender.EmailID1);
        //                String smtpPassword = DecryptString(Convert.ToString(Sender.EmailPassword));
        //                Boolean sslEnabled = false;//Convert.ToBoolean(dtEmailConfig.SSLEnabled);              
        //                message.IsBodyHtml = true;
        //                System.Net.Mail.MailAddress senderID = new System.Net.Mail.MailAddress(adminEmailID, SendName);
        //                message.Sender = senderID;
        //                System.Net.Mail.MailAddress mailID = new System.Net.Mail.MailAddress(Recipient, Recipient);
        //                message.To.Add(mailID);
        //                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        //                message.From = senderID;
        //                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        //                SmtpClient client = new SmtpClient(smtpClientHost);
        //                client.Credentials = new System.Net.NetworkCredential(smtpUserID, smtpPassword);
        //                client.EnableSsl = sslEnabled;
        //                client.Send(message);
        //                Task taskA = Task.Factory.StartNew(() => Thread.SpinWait(120000));
        //                taskA.Wait(120000);
        //                sent = true;

        //            }
        //            catch (Exception ex)
        //            {
        //                // CCLib.Logger.ErrorException("SendEmailsWithAuthenticate", ex);
        //                bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
        //                sent = false;
        //            }
        //            return sent;
        //        }


        //        public static Boolean SendEmailsWithAuthenticate(MailMessage message, EmailFor emailFor, ConfigFile dtEmailConfig, ExUser dtAdminData)
        //        {
        //            bool sent = false;
        //            try
        //            {

        //                String UserEmailID = DecryptString(dtAdminData.ExUser1);
        //                //String adminEmailID = dtEmailConfig.SMTPUserid;
        //                String adminEmailPerson = Convert.ToString(dtEmailConfig.SiteAdminUserCode);
        //                String adminEmailID = "";
        //                String smtpClientHost = "";
        //                String smtpUserID = "";
        //                String smtpPassword = "";
        //                //if ((dtAdminData.EmailPassword != "" && dtAdminData.EmailPassword != null) && (HttpContext.Current.Session["CompanySMTPHost"] != null && HttpContext.Current.Session["CompanySMTPHost"] != ""))
        //                // {
        //                //     adminEmailID = Convert.ToString(dtAdminData.EmailID1);
        //                //     smtpClientHost = Convert.ToString(HttpContext.Current.Session["CompanySMTPHost"]);
        //                //     smtpUserID = Convert.ToString(dtAdminData.EmailID1);
        //                //     smtpPassword = DecryptString(Convert.ToString(dtAdminData.EmailPassword));
        //                // }
        //                // else
        //                // {
        //                adminEmailID = dtEmailConfig.SMTPUserid;
        //                smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                smtpUserID = Convert.ToString(dtEmailConfig.SMTPUserid);
        //                smtpPassword = DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));
        //                //}

        //                //String smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);                             
        //                Boolean sslEnabled = Convert.ToBoolean(dtEmailConfig.SSLEnabled);
        //                if (adminEmailID.Length == 0 || smtpClientHost.Length == 0 || smtpUserID.Length == 0)
        //                {
        //                    //MessageBox.ShowAlert(CommonMessages.EmailFailure);
        //                    return false;
        //                    sent = false;
        //                }
        //                message.IsBodyHtml = true;
        //                message.Body = message.Body.Replace("#EmailBy#", adminEmailPerson);
        //                message.Body = message.Body.Replace("#UserName#", Convert.ToString(HttpContext.Current.Session["Username"]));
        //                System.Net.Mail.MailAddress senderID = new System.Net.Mail.MailAddress(adminEmailID, UserEmailID);
        //                message.Sender = senderID;
        //                // Delivery notifications
        //                //

        //                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        //                switch (emailFor)
        //                {
        //                    case EmailFor.Other:
        //                        message.From = senderID;
        //                        break;

        //                }
        //                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        //                SmtpClient client = new SmtpClient(smtpClientHost);
        //                client.Credentials = new System.Net.NetworkCredential(smtpUserID, smtpPassword);
        //                client.EnableSsl = sslEnabled;
        //                client.Send(message);
        //                sent = true;

        //            }
        //            catch (Exception ex)
        //            {
        //                // CCLib.Logger.ErrorException("SendEmailsWithAuthenticate", ex);
        //                bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
        //                sent = false;
        //            }
        //            return sent;
        //        }


        //        public static Boolean SendHtmlEmailsWithAuthenticate(MailMessage message, EmailFor emailFor, ConfigFile dtEmailConfig, User dtAdminData)
        //        {
        //            bool sent = false;
        //            try
        //            {
        //                String UserEmailID = DecryptString(dtAdminData.EmailId);
        //                //String adminEmailID = "pushkar.iitb@gmail.com"; //dtEmailConfig.SMTPUserid;
        //                //String adminEmailPerson = Convert.ToString(dtEmailConfig.SiteAdminUserCode);
        //                //String smtpClientHost = "smtp.sendgrid.net";// Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                //String smtpUserID = "pushkar.iitb@gmail.com";//Convert.ToString(dtEmailConfig.SMTPUserid);
        //                //String smtpPassword = "qfMrgzPg1"; //DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));

        //                //String adminEmailID = dtEmailConfig.SMTPUserid;
        //                String adminEmailPerson = Convert.ToString(dtEmailConfig.SiteAdminUserCode);
        //                //String smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                //String smtpUserID = Convert.ToString(dtEmailConfig.SMTPUserid);
        //                //String smtpPassword = DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));
        //                String adminEmailID = "";
        //                String smtpClientHost = "";
        //                String smtpUserID = "";
        //                String smtpPassword = "";
        //                if ((dtAdminData.EmailPassword != "" && dtAdminData.EmailPassword != null) && (dtAdminData.SMTPHost != null && dtAdminData.SMTPHost != ""))
        //                {
        //                    adminEmailID = Convert.ToString(dtAdminData.EmailID1);
        //                    smtpClientHost = dtAdminData.SMTPHost;
        //                    smtpUserID = Convert.ToString(dtAdminData.EmailID1);
        //                    smtpPassword = DecryptString(Convert.ToString(dtAdminData.EmailPassword));
        //                }
        //                else
        //                {
        //                    adminEmailID = dtEmailConfig.SMTPUserid;
        //                    smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                    smtpUserID = Convert.ToString(dtEmailConfig.SMTPUserid);
        //                    smtpPassword = DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));
        //                }

        //                Boolean sslEnabled = Convert.ToBoolean(dtEmailConfig.SSLEnabled);
        //                if (adminEmailID.Length == 0 || smtpClientHost.Length == 0 || smtpUserID.Length == 0)
        //                {
        //                    //MessageBox.ShowAlert(CommonMessages.EmailFailure);
        //                    return false;
        //                    sent = false;
        //                }
        //                message.IsBodyHtml = true;


        //                message.Body = message.Body.Replace("#EmailBy#", adminEmailPerson);
        //                message.Body = message.Body.Replace("#UserName#", Convert.ToString(HttpContext.Current.Session["Username"]));

        //                //public MailAddress(string address, string displayName);
        //                //MailAddress senderID = new MailAddress(adminEmailID, UserEmailID);
        //                System.Net.Mail.MailAddress senderID = new System.Net.Mail.MailAddress(adminEmailID, adminEmailID);
        //                message.Sender = senderID;
        //                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        //                switch (emailFor)
        //                {
        //                    case EmailFor.Other:
        //                        message.From = senderID;
        //                        break;
        //                }
        //                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        //                SmtpClient client = new SmtpClient(smtpClientHost);
        //                client.Credentials = new System.Net.NetworkCredential(smtpUserID, smtpPassword);
        //                client.EnableSsl = sslEnabled;
        //                client.Send(message);
        //                sent = true;
        //            }
        //            catch (Exception ex)
        //            {
        //                // CCLib.Logger.ErrorException("SendEmailsWithAuthenticate", ex);
        //                bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
        //                sent = false;
        //            }
        //            return sent;
        //        }

        //        public static Boolean SendHtmlEmailsToClientUserWithAuthenticate(MailMessage message, EmailFor emailFor, ConfigFile dtEmailConfig, User dtAdminData)
        //        {
        //            bool sent = false;
        //            try
        //            {
        //                String UserEmailID = DecryptString(dtAdminData.EmailId);


        //                Guid objGuid = new Guid();
        //                objGuid = Guid.NewGuid();
        //                String MessageID = "<" + objGuid.ToString() + ">";

        //                string host = "";

        //                // message.Headers.Add("MessageId", "bipin"); //Set Message-ID in Email Header


        //                //String adminEmailID = "pushkar.iitb@gmail.com"; //dtEmailConfig.SMTPUserid;
        //                //String adminEmailPerson = Convert.ToString(dtEmailConfig.SiteAdminUserCode);
        //                //String smtpClientHost = "smtp.sendgrid.net";// Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                //String smtpUserID = "pushkar.iitb@gmail.com";//Convert.ToString(dtEmailConfig.SMTPUserid);
        //                //String smtpPassword = "qfMrgzPg1"; //DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));

        //                //String adminEmailID = dtEmailConfig.SMTPUserid;
        //                String adminEmailPerson = Convert.ToString(dtEmailConfig.SiteAdminUserCode);
        //                //String smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                //String smtpUserID = Convert.ToString(dtEmailConfig.SMTPUserid);
        //                //String smtpPassword = DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));
        //                String adminEmailID = "";
        //                String smtpClientHost = "";
        //                String smtpUserID = "";
        //                String smtpPassword = "";
        //                if ((dtAdminData.EmailPassword != "" && dtAdminData.EmailPassword != null) && (dtAdminData.SMTPHost != null && dtAdminData.SMTPHost != ""))
        //                {
        //                    adminEmailID = Convert.ToString(dtAdminData.EmailID1);
        //                    smtpClientHost = dtAdminData.SMTPHost;
        //                    smtpUserID = Convert.ToString(dtAdminData.EmailID1);
        //                    smtpPassword = DecryptString(Convert.ToString(dtAdminData.EmailPassword));
        //                    host = "imap." + Convert.ToString(adminEmailID.Split('@')[1]);
        //                }
        //                else
        //                {
        //                    adminEmailID = dtEmailConfig.SMTPUserid;
        //                    smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                    smtpUserID = Convert.ToString(dtEmailConfig.SMTPUserid);
        //                    smtpPassword = DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));
        //                    host = "imap." + Convert.ToString(adminEmailID.Split('@')[1]);
        //                }

        //                Boolean sslEnabled = Convert.ToBoolean(dtEmailConfig.SSLEnabled);
        //                if (adminEmailID.Length == 0 || smtpClientHost.Length == 0 || smtpUserID.Length == 0)
        //                {
        //                    //MessageBox.ShowAlert(CommonMessages.EmailFailure);
        //                    return false;
        //                    sent = false;
        //                }
        //                message.IsBodyHtml = true;


        //                message.Body = message.Body.Replace("#EmailBy#", adminEmailPerson);
        //                message.Body = message.Body.Replace("#UserName#", Convert.ToString(HttpContext.Current.Session["Username"]));

        //                //public MailAddress(string address, string displayName);
        //                //MailAddress senderID = new MailAddress(adminEmailID, UserEmailID);
        //                System.Net.Mail.MailAddress senderID = new System.Net.Mail.MailAddress(adminEmailID, adminEmailID);
        //                message.Sender = senderID;
        //                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        //                switch (emailFor)
        //                {
        //                    case EmailFor.Other:
        //                        message.From = senderID;
        //                        break;
        //                }
        //                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        //                SmtpClient client = new SmtpClient(smtpClientHost);
        //                client.Credentials = new System.Net.NetworkCredential(smtpUserID, smtpPassword);
        //                //client.EnableSsl = sslEnabled;
        //                client.EnableSsl = true;
        //                client.Send(message);
        //                sent = true;



        //                var imapClient = new ImapX.ImapClient(host, false);
        //                if (imapClient.Connect())
        //                {
        //                    if (imapClient.Login(smtpUserID, smtpPassword))
        //                    { //imapClient.Folders.Drafts.AppendMessage(message);
        //                      //imapClient.Folders.Drafts.SubFolders.Add("bipin");
        //                      //imapClient.Folders.All.AppendMessage(message);
        //                        imapClient.Folders.Sent.AppendMessage(message);
        //                        // Uploading the sent message to the Sent folder
        //                        //imapClient.Folder.Sent.AppendMessage(message);
        //                        //ImapX.Collections.FolderCollection folders = imapClient.Folders;
        //                        //foreach (Folder myfolder in folders)
        //                        //{
        //                        //    string str = myfolder.Name;
        //                        //}
        //                    }
        //                }





        //            }
        //            catch (Exception ex)
        //            {
        //                // CCLib.Logger.ErrorException("SendEmailsWithAuthenticate", ex);
        //                bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
        //                sent = false;
        //            }
        //            return sent;
        //        }

        //        public static Boolean SendHtmlEmailsWithAuthenticaToColleague(MailMessage message, EmailFor emailFor, ConfigFile dtEmailConfig, User dtAdminData)
        //        {
        //            bool sent = false;
        //            try
        //            {

        //                String UserEmailID = DecryptString(dtAdminData.EmailId);
        //                //String adminEmailID = "pushkar.iitb@gmail.com"; //dtEmailConfig.SMTPUserid;
        //                //String adminEmailPerson = Convert.ToString(dtEmailConfig.SiteAdminUserCode);
        //                //String smtpClientHost = "smtp.sendgrid.net";// Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                //String smtpUserID = "pushkar.iitb@gmail.com";//Convert.ToString(dtEmailConfig.SMTPUserid);
        //                //String smtpPassword = "qfMrgzPg1"; //DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));

        //                //String adminEmailID = dtEmailConfig.SMTPUserid;
        //                String adminEmailPerson = Convert.ToString(dtEmailConfig.SiteAdminUserCode);
        //                //String smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                //String smtpUserID = Convert.ToString(dtEmailConfig.SMTPUserid);
        //                //String smtpPassword = DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));

        //                String adminEmailID = "";
        //                String smtpClientHost = "";
        //                String smtpUserID = "";
        //                String smtpPassword = "";
        //                if ((dtAdminData.EmailPassword != "" && dtAdminData.EmailPassword != null) && (HttpContext.Current.Session["CompanySMTPHost"] != null && HttpContext.Current.Session["CompanySMTPHost"] != ""))
        //                {
        //                    adminEmailID = Convert.ToString(dtAdminData.EmailID1);
        //                    smtpClientHost = Convert.ToString(HttpContext.Current.Session["CompanySMTPHost"]);
        //                    smtpUserID = Convert.ToString(dtAdminData.EmailID1);
        //                    smtpPassword = DecryptString(Convert.ToString(dtAdminData.EmailPassword));
        //                }
        //                else
        //                {
        //                    adminEmailID = dtEmailConfig.SMTPUserid;
        //                    smtpClientHost = Convert.ToString(dtEmailConfig.SmtpClientHost);
        //                    smtpUserID = Convert.ToString(dtEmailConfig.SMTPUserid);
        //                    smtpPassword = DecryptString(Convert.ToString(dtEmailConfig.SMTPPassword));
        //                }

        //                Boolean sslEnabled = Convert.ToBoolean(dtEmailConfig.SSLEnabled);
        //                if (adminEmailID.Length == 0 || smtpClientHost.Length == 0 || smtpUserID.Length == 0)
        //                {
        //                    //MessageBox.ShowAlert(CommonMessages.EmailFailure);
        //                    return false;
        //                    sent = false;
        //                }
        //                message.IsBodyHtml = true;


        //                message.Body = message.Body.Replace("#EmailBy#", adminEmailPerson);
        //                message.Body = message.Body.Replace("#UserName#", Convert.ToString(HttpContext.Current.Session["Username"]));

        //                //public MailAddress(string address, string displayName);
        //                //MailAddress senderID = new MailAddress(adminEmailID, UserEmailID);
        //                System.Net.Mail.MailAddress senderID = new System.Net.Mail.MailAddress(adminEmailID, "WorkPack");
        //                message.Sender = senderID;
        //                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
        //                switch (emailFor)
        //                {
        //                    case EmailFor.Other:
        //                        message.From = senderID;
        //                        break;
        //                }
        //                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        //                SmtpClient client = new SmtpClient(smtpClientHost);
        //                client.Credentials = new System.Net.NetworkCredential(smtpUserID, smtpPassword);
        //                client.EnableSsl = sslEnabled;
        //                client.Send(message);
        //                sent = true;
        //            }
        //            catch (Exception ex)
        //            {
        //                // CCLib.Logger.ErrorException("SendEmailsWithAuthenticate", ex);
        //                bool rethrow = UserInterfaceExceptionHandler.HandleException(ref ex);
        //                sent = false;
        //            }
        //            return sent;
        //        }




        //        public static string ConvertDataTabletoString(DataTable dtrecord)
        //        {
        //            DataTable dt = new DataTable();
        //            dt = dtrecord;

        //            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        //            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        //            Dictionary<string, object> row;
        //            foreach (DataRow dr in dt.Rows)
        //            {
        //                row = new Dictionary<string, object>();
        //                foreach (DataColumn col in dt.Columns)
        //                {
        //                    row.Add(col.ColumnName, dr[col]);
        //                }
        //                rows.Add(row);
        //            }
        //            return serializer.Serialize(rows);
        //        }
        //        public static List<object> ConvertDTtoList(DataTable dtrecord)
        //        {
        //            List<object> objListOfobjects = new List<object>();
        //            foreach (DataRow dRow in dtrecord.Rows)
        //            {
        //                Hashtable hashtable = new Hashtable();
        //                for (int i = dtrecord.Columns.Count - 1; i >= 0; i--)
        //                {
        //                    if (dtrecord.Columns[i].DataType == typeof(int))
        //                    {
        //                        hashtable.Add(dtrecord.Columns[i].ColumnName, int.Parse(dRow[dtrecord.Columns[i].ColumnName].ToString() == "" ? "0" : dRow[dtrecord.Columns[i].ColumnName].ToString()));
        //                    }
        //                    else
        //                    {
        //                        string value = Convert.ToString(dRow[dtrecord.Columns[i].ColumnName]) == "0.00" ? "" : dRow[dtrecord.Columns[i].ColumnName].ToString();
        //                        hashtable.Add(dtrecord.Columns[i].ColumnName, value);
        //                    }
        //                }
        //                objListOfobjects.Add(hashtable);
        //            }
        //            return objListOfobjects;

        //        }
        //        public static DateTime ConvertStringToDateTime(String strDate)
        //        {
        //            CultureInfo ci = new CultureInfo("en-GB");
        //            return Convert.ToDateTime(strDate, ci);

        //        }

        //        public static DateTime ConvertDateIntoMMDDYYYY(String strDate)
        //        {

        //            String[] str = strDate.Split('/');
        //            String strdate = str[1] + "/" + str[0] + "/" + str[2];
        //            return Convert.ToDateTime(strdate);



        //        }


        //        public static string ConvertDateIntoDDMMYYYY(string strDate)
        //        {
        //            String[] str = strDate.ToString().Split('/');
        //            String strdate = str[1] + "/" + str[0] + "/" + str[2].Substring(0, 4);
        //            return strdate;
        //        }



        //        public static DataTable ConvertToDataTable<T>(IList<T> data)
        //        {
        //            PropertyDescriptorCollection properties =
        //               TypeDescriptor.GetProperties(typeof(T));
        //            DataTable table = new DataTable();
        //            foreach (PropertyDescriptor prop in properties)
        //                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        //            foreach (T item in data)
        //            {
        //                DataRow row = table.NewRow();
        //                foreach (PropertyDescriptor prop in properties)
        //                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
        //                table.Rows.Add(row);
        //            }
        //            return table;
        //        }
        //        public static string TaskStatusIDByKey(int key)
        //        {
        //            string TaskStatus = "";
        //            switch (key)
        //            {
        //                case 0:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.Draft);
        //                    break;
        //                case 1:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.ResourceAwaited);
        //                    break;
        //                case 2:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.ResourceAccepted);
        //                    break;
        //                case 3:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.SendToFocalPoint);
        //                    break;
        //                case 4:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.UnderDiscussion);
        //                    break;
        //                case 5:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.TaskAssigned);
        //                    break;
        //                case 6:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.AcceptedByTaskOwner);
        //                    break;
        //                case 7:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.TaskStarted);
        //                    break;
        //                case 8:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.Cancelled);
        //                    break;
        //                case 9:
        //                    TaskStatus = Convert.ToString(Common.TaskStatusID.Closed);
        //                    break;
        //                default:
        //                    TaskStatus = "";
        //                    break;

        //            }
        //            return TaskStatus;
        //        }
        //        public static List<List<uint>> XLGetHiddenRowsOrCols(string fileName, string sheetName, ref DataTable dt)
        //        {
        //            // Given a workbook and a worksheet name, return 
        //            // either a list of hidden row numbers, or a list 
        //            // of hidden column numbers. If detectRows is true, return
        //            // hidden rows. If detectRows is false, return hidden columns. 
        //            // Rows and columns are numbered starting with 1.
        //            List<List<uint>> returnlst = new List<List<uint>>();
        //            List<uint> itemList = new List<uint>();

        //            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, false))
        //            {
        //                WorkbookPart wbPart = document.WorkbookPart;

        //                Sheet theSheet = wbPart.Workbook.Descendants<Sheet>().Where((s) => s.Name == sheetName.TrimEnd('$')).FirstOrDefault();
        //                if (theSheet == null)
        //                {
        //                    throw new ArgumentException("sheetName");
        //                }
        //                else
        //                {
        //                    // The sheet does exist.
        //                    WorksheetPart wsPart = (WorksheetPart)(wbPart.GetPartById(theSheet.Id));
        //                    Worksheet ws = wsPart.Worksheet;
        //                    // Retrieve hidden rows.
        //                    itemList = ws.Descendants<Row>().Where((r) => r.Hidden != null && r.Hidden.Value).Select(r => r.RowIndex.Value).ToList<uint>();
        //                    // delete hidden rows from datatable
        //                    for (int i = 0; i < itemList.Count(); i++)
        //                    {
        //                        DataRow dr = dt.Rows[(int)itemList[i] - 2];
        //                        dr.Delete();


        //                    }
        //                    dt.AcceptChanges();
        //                    returnlst.Add(itemList);
        //                    itemList = new List<uint>();
        //                    // Retrieve hidden columns.
        //                    var cols = ws.Descendants<Column>().
        //                      Where((c) => c.Hidden != null && c.Hidden.Value);
        //                    List<string> lst = new List<string>();
        //                    foreach (Column item in cols)
        //                    {
        //                        for (uint i = item.Min.Value; i <= item.Max.Value; i++)
        //                        {
        //                            lst.Add(item.LocalName);
        //                            itemList.Add(i);
        //                        }
        //                    }
        //                    // delete hidden coloumn from datatable
        //                    for (int i = 0; i < itemList.Count(); i++)
        //                    {
        //                        dt.Columns.RemoveAt((int)itemList[i] - 1 - i);
        //                        //dt.AcceptChanges();
        //                    }

        //                    returnlst.Add(itemList);
        //                }

        //            }
        //            return returnlst;
        //        }
        //        #endregion







        //        //    public static void CreatePackage(string filePath)
        //        //    {
        //        //        using (SpreadsheetDocument package = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
        //        //        {
        //        //            CreateParts(package);
        //        //            //CreateExcelParts();
        //        //        }
        //        //    }



        //        //    // Adds child parts and generates content of the specified part
        //        //    private static void CreateParts(SpreadsheetDocument document)
        //        //    {
        //        //        WorkbookPart workbookPart1 = document.AddWorkbookPart();
        //        //        GenerateWorkbookPart1Content(workbookPart1);

        //        //        WorksheetPart worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
        //        //        GenerateWorksheetPart1Content(worksheetPart1);
        //        //    }




        //        //    private static void GenerateWorkbookPart1Content(WorkbookPart workbookPart1)
        //        //    {
        //        //        Workbook workbook1 = new Workbook();
        //        //        workbook1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

        //        //        Sheets sheets1 = new Sheets();
        //        //        Sheet sheet1 = new Sheet() { Name = "Sheet1", SheetId = (UInt32Value)1U, Id = "rId1" };
        //        //        sheets1.Append(sheet1);

        //        //        workbook1.Append(sheets1);
        //        //        workbookPart1.Workbook = workbook1;
        //        //    }



        //        //    private static void GenerateWorksheetPart1Content(WorksheetPart worksheetPart1)
        //        //    {
        //        //        Worksheet worksheet1 = new Worksheet();
        //        //        SheetData sheetData1 = new SheetData();

        //        //        Row row1 = new Row();
        //        //        Cell cell1 = new Cell() { CellReference = "A1", DataType = CellValues.InlineString };
        //        //        InlineString inlineString1 = new InlineString();
        //        //        Text text1 = new Text();
        //        //        text1.Text = "hello";
        //        //        inlineString1.Append(text1);
        //        //        cell1.Append(inlineString1);
        //        //        row1.Append(cell1);

        //        //        sheetData1.Append(row1);
        //        //        worksheet1.Append(sheetData1);
        //        //        worksheetPart1.Worksheet = worksheet1;
        //        //    }





        //        //    public static DataTable ConvertListOfObjectToDataTable(List<object> lst)
        //        //    {
        //        //        DataTable dt = new DataTable();
        //        //        dt.TableName = "Table";
        //        //        for (int i = 0; i < lst.Count; i++)
        //        //        {
        //        //            DataRow dr = dt.NewRow();
        //        //            string[] arr = lst[i].ToString().Trim('{').Trim('}').Split(',');
        //        //            for (int j = 0; j < arr.Length; j++)
        //        //            {
        //        //                if (i == 0)
        //        //                {
        //        //                    dt.Columns.Add(arr[j].Split('=')[0].TrimEnd());
        //        //                }
        //        //                dr[j] = arr[j].Split('=')[1].TrimEnd();
        //        //            }
        //        //            dt.Rows.Add(dr);
        //        //        }

        //        //        return dt;
        //        //    }

        //        //    public static int? ToNullableInt32(this string s)
        //        //    {
        //        //        int i;
        //        //        if (Int32.TryParse(s, out i)) return i;
        //        //        return null;
        //        //    }
        //        //}

        //        //public static class DateTimeExtensions
        //        //{
        //        //    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        //        //    {
        //        //        int diff = dt.DayOfWeek - startOfWeek;
        //        //        if (diff < 0)
        //        //        {
        //        //            diff += 7;
        //        //        }

        //        //        return dt.AddDays(-1 * diff).Date;
        //        //    }
        //        //}


        //        //public class ExuserMapping
        //        //{

        //        //    public string GridColname { get; set; }

        //        //    public string TableColname { get; set; }



        //        //}




        //        //public class AjaxFileUploader : IHttpHandler
        //        //{
        //        //    public void ProcessRequest(HttpContext context)
        //        //    {
        //        //        if (context.Request.Files.Count > 0)
        //        //        {
        //        //            string path = context.Server.MapPath("~/Temp");
        //        //            if (!Directory.Exists(path))
        //        //                Directory.CreateDirectory(path);
        //        //            var file = context.Request.Files[0];
        //        //            string fileName;
        //        //            if (HttpContext.Current.Request.Browser.Browser.ToUpper() == "IE")
        //        //            {
        //        //                string[] files = file.FileName.Split(new char[] { '\\' });
        //        //                fileName = files[files.Length - 1];
        //        //            }
        //        //            else
        //        //            {
        //        //                fileName = file.FileName;
        //        //            }
        //        //            string strFileName = fileName;
        //        //            fileName = Path.Combine(path, fileName);
        //        //            file.SaveAs(fileName);
        //        //            string msg = "{";
        //        //            msg += string.Format("error:'{0}',\n", string.Empty);
        //        //            msg += string.Format("msg:'{0}'\n", strFileName);
        //        //            msg += "}";
        //        //            context.Response.Write(msg);
        //        //        }
        //        //    }
        //        //    public bool IsReusable
        //        //    {
        //        //        get { return true; }
        //        //    }
        //        //}



        //        //public static class ExtensionsGenerel
        //        //{
        //        //    public static void SetProperty(this object obj, string propertyName, object value)
        //        //    {
        //        //        var propertyInfo = obj.GetType().GetProperty(propertyName);
        //        //        if (propertyInfo == null) return;

        //        //        Type t = Type.GetType(propertyInfo.PropertyType.FullName);
        //        //        object d;

        //        //        if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
        //        //        {
        //        //            if (value == null)
        //        //                d = null;
        //        //            else
        //        //                d = Convert.ChangeType(value, t.GetGenericArguments()[0]);
        //        //        }
        //        //        else
        //        //        {
        //        //            d = Convert.ChangeType(value, t);
        //        //        }

        //        //        propertyInfo.SetValue(obj, d);
        //        //    }

        //        //    public static T? GetValue<T>(object value) where T : struct
        //        //    {
        //        //        if (value == null || value is DBNull) return null;
        //        //        if (value is T) return (T)value;
        //        //        return (T)Convert.ChangeType(value, typeof(T));
        //        //    }

        //        //    public static bool IsBetween(this DateTime dt, DateTime? start, DateTime? end)
        //        //    {
        //        //        if (start.HasValue && end.HasValue)
        //        //            return dt >= start && dt <= end;
        //        //        else
        //        //            return true;
        //        //    }


        //        //    private static object ChangeType(object value, Type conversion)
        //        //    {
        //        //        var t = conversion;

        //        //        if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
        //        //        {
        //        //            if (value == null)
        //        //            {
        //        //                return null;
        //        //            }

        //        //            t = Nullable.GetUnderlyingType(t);
        //        //        }

        //        //        return Convert.ChangeType(value, t);
        //        //    }
        //        //}









    }
}