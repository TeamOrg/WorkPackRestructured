//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Diagnostics;
//using System.Net.Mail;
//using System.Net;
//using System.IO;
//using System.Web;


//namespace CommonLibrary
//{
//    public class Email
//    {

//        public class SSLNetworkCredential
//        {
//            public string UserName { get; set; }
//            public string Password { get; set; }
//            public string Domain { get; set; }
//            public SSLNetworkCredential(string userName, string password)
//            {
//                this.UserName = userName;
//                this.Password = password;
//            }
//            public SSLNetworkCredential(string userName, string password, string domain)
//            {
//                this.UserName = userName;
//                this.Password = password;
//                this.Domain = domain;
//            }
//        }

//        public class SendMail
//        {
//            public string From { get; set; }
//            public string To { get; set; }
//            public string CC { get; set; }
//            public string BCC { get; set; }
//            public string Periority { get; set; }
//            public string Attachment { get; set; }
//            public string Subject { get; set; }
//            public bool IsBodyIsInHTML { get; set; }
//            public string Path { get; set; }
//            public string Content { get; set; }
//            public bool IsSslEnabled { get; set; }
//            public SSLNetworkCredential SSLNetworkCredential { get; set; }

//            private SSLNetworkCredential m_SSLNetworkCredential;
//            //public bool SendMail()
//            //{
//            //    string strTempBody = string.Empty;
//            //    bool IsImageEmbadded = false;

//            //    if (Content == null)
//            //    {
//            //        strTempBody = LoadPage(Path);
//            //    }
//            //    else
//            //    {
//            //        strTempBody = Content;
//            //    }

//            //    string strBody = string.Empty;
//            //    AlternateView view = null;

//            //    if (strTempBody.Contains("src=\"") == true)
//            //    {
//            //        int intImageIndex = 0;
//            //        IsImageEmbadded = true;

//            //        IList<string> imageFiles = new List<string>();
//            //        while (strTempBody.Contains("src=\""))
//            //        {
//            //            strBody += strTempBody.Substring(0, strTempBody.IndexOf("src=") + 5);
//            //            strTempBody = strTempBody.Substring(strTempBody.IndexOf("src=") + 5);
//            //            strBody += "cid:image" + intImageIndex.ToString();

//            //            string strFileName = ResolveUrl(strTempBody.Substring(0, strTempBody.IndexOf("\"")));
//            //            strTempBody = strTempBody.Substring(strTempBody.IndexOf("\"") + 1);

//            //            imageFiles.Add(strFileName);

//            //            strBody += "\"";
//            //            intImageIndex += 1;
//            //        }

//            //        strBody += strTempBody;

//            //        view = AlternateView.CreateAlternateViewFromString(strBody, null, "text/html");

//            //        intImageIndex -= 1;

//            //        for (int intIndex = intImageIndex; intIndex >= 0; intIndex += -1)
//            //        {
//            //            LinkedResource linked = new LinkedResource(imageFiles[intIndex]);
//            //            linked.ContentId = "image" + intIndex.ToString();
//            //            view.LinkedResources.Add(linked);
//            //        }
//            //    }
//            //    else
//            //    {
//            //        strBody += strTempBody;
//            //    }


//            //    try
//            //    {
//            //        SmtpClient smtp = new SmtpClient(ConfigHelper.SMTP);
//            //        MailMessage mssg = new MailMessage();
//            //        mssg.From = new MailAddress(From);
//            //        mssg.Subject = Subject;

//            //        if (IsImageEmbadded == true)
//            //        {
//            //            mssg.AlternateViews.Add(view);
//            //        }
//            //        else
//            //        {
//            //            mssg.Body = strBody;
//            //        }


//            //        if (IsSslEnabled == true)
//            //        {
//            //            smtp.EnableSsl = true;

//            //            NetworkCredential myCreds = new NetworkCredential(SSLNetworkCredential.UserName, SSLNetworkCredential.Password, SSLNetworkCredential.Domain);
//            //            smtp.Credentials = myCreds;
//            //        }


//            //        if (To.Trim().Length > 0)
//            //        {
//            //            foreach (string sTo in To.Split(",".ToCharArray()))
//            //            {
//            //                mssg.To.Add(sTo);
//            //            }
//            //        }

//            //        if (CC.Trim().Length > 0)
//            //        {
//            //            foreach (string sCC in CC.Split(",".ToCharArray()))
//            //            {
//            //                mssg.CC.Add(sCC);
//            //            }
//            //        }


//            //        if (BCC.Trim().Length > 0)
//            //        {
//            //            foreach (string sBCC in BCC.Split(",".ToCharArray()))
//            //            {
//            //                mssg.Bcc.Add(sBCC);
//            //            }
//            //        }

//            //        if (Attachment.Trim().Length > 0)
//            //        {
//            //            foreach (string sAttachment in Attachment.Split(",".ToCharArray()))
//            //            {
//            //                Attachment attachment__1 = new Attachment(sAttachment);
//            //                mssg.Attachments.Add(attachment__1);
//            //            }
//            //        }

//            //        MailPriority mailPeriority = MailPriority.Normal;
//            //        switch (Periority)
//            //        {
//            //            case "2":
//            //                mailPeriority = MailPriority.High;
//            //                break; // TODO: might not be correct. Was : Exit Select

//            //                break;
//            //            case "0":
//            //                mailPeriority = MailPriority.Low;
//            //                break; // TODO: might not be correct. Was : Exit Select

//            //                break;
//            //            case "1":
//            //                mailPeriority = MailPriority.Normal;
//            //                break; // TODO: might not be correct. Was : Exit Select

//            //                break;
//            //        }

//            //        mssg.Priority = mailPeriority;
//            //        mssg.BodyEncoding = System.Text.Encoding.Default;
//            //        mssg.SubjectEncoding = System.Text.Encoding.Default;
//            //        mssg.IsBodyHtml = IsBodyIsInHTML;
//            //        smtp.Send(mssg);

//            //        return true;
//            //    }
//            //    catch (Exception ex)
//            //    {
//            //    }
//            //    return false;
//            //}

//            public string LoadPage(string url)
//            {
//                WebRequest objRequest = System.Net.HttpWebRequest.Create(url);
//                StreamReader sr = new StreamReader(objRequest.GetResponse().GetResponseStream());
//                string result = sr.ReadToEnd();
//                sr.Close();
//                return result;
//            }

//            public string ResolveUrl(string relativeUrl)
//            {
//                string retVal = string.Empty;
//                if (relativeUrl == null)
//                {
//                    throw new ArgumentNullException("relativeUrl");
//                }

//                if (relativeUrl.StartsWith("../") == true)
//                {
//                    retVal = HttpContext.Current.Request.PhysicalApplicationPath.Substring(0, HttpContext.Current.Request.PhysicalApplicationPath.LastIndexOf("\\"));
//                    while (relativeUrl.StartsWith("../"))
//                    {
//                        relativeUrl = relativeUrl.Substring(3);
//                        retVal = retVal.Substring(0, retVal.LastIndexOf("\\"));
//                    }
//                    retVal = retVal + "\\" + relativeUrl;
//                }
//                else if (relativeUrl.StartsWith("/") == true)
//                {
//                    retVal = HttpContext.Current.Request.PhysicalApplicationPath + relativeUrl;
//                }
//                else if (relativeUrl.Length > 0)
//                {
//                    retVal = HttpContext.Current.Request.PhysicalApplicationPath + relativeUrl;
//                }

//                return retVal;
//            }
//        }

//    }
//}