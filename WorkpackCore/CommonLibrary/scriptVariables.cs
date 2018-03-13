//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Web.UI;
//using System.Web;
//using System.Reflection;
//using System.Web.Script.Serialization;

//namespace CommonLibrary
//{
//    /// <summary>
//    /// Provides an easy way for server code to publish strings into client script code.
//    /// This object basically provides a mechanism for adding key value pairs and embedding
//    /// those values into an object that is hosted on the client.        
//    /// </summary>
//    public class scriptVariables
//    {

//        /// <summary>
//        /// Internally holds all script variables declared
//        /// </summary>
//        Dictionary<string, object> ScriptVariables = new Dictionary<string, object>();


//        /// <summary>
//        /// Internally tracked reference to the Page object
//        /// </summary>
//        Page Page = null;


//        /// <summary>
//        /// The name of the object generated in client script code
//        /// </summary>
//        public string ClientObjectName
//        {
//            get { return _ClientObjectName; }
//            set { _ClientObjectName = value; }
//        }
//        private string _ClientObjectName = "serverVars";

//        /// <summary>
//        /// Determines whether the output object script is rendered
//        /// automatically as part of Page PreRenderComplete. If false
//        /// you can manually call the RenderClientScript() method to
//        /// retrieve the script and embed it yourself.
//        /// </summary>        
//        public bool AutoRenderClientScript
//        {
//            get { return _AutoRenderClientScript; }
//            set { _AutoRenderClientScript = value; }
//        }
//        private bool _AutoRenderClientScript = true;


//        /// <summary>
//        /// Full constructor that receives an instance of any control object
//        /// and the client name of the generated script object that contains
//        /// the specified properties.
//        /// </summary>
//        /// <param name="control"></param>
//        /// <param name="clientObjectName"></param>
//        public scriptVariables(Control control, string clientObjectName)
//        {
//            if (control == null)
//                // Note: this will fail if called from Page Contstructor
//                //       ie. wwScriptVariables scripVars = new wwScriptVariables();
//                this.Page = HttpContext.Current.Handler as Page;
//            else
//                this.Page = control.Page;

//            if (this.Page == null)
//                throw new ArgumentException("Could not retrieve a Page instance in wwScriptVariables.\r\n Either provide a Control or Page reference to the wwScriptVariables constructor or intialize the class in OnInit() of the page or later.");

//            if (!string.IsNullOrEmpty(clientObjectName))
//                this.ClientObjectName = clientObjectName;

//            // *** Force RenderClientScript to be called before the page renders
//            this.Page.PreRenderComplete += new EventHandler(Page_PreRenderComplete);
//        }
//        /// <summary>
//        /// This constructor only takes an instance of a Control. The name of the
//        /// client object will be serverVars.
//        /// </summary>
//        /// <param name="control"></param>
//        public scriptVariables(Control control)
//            : this(control, "serverVars")
//        {
//        }
//        /// <summary>
//        /// This constructor can only be called AFTER a page instance has been created.
//        /// This means OnInit() or later, but not in the constructor of the page.
//        /// 
//        /// The name of the client object will be serverVars.
//        /// </summary>
//        public scriptVariables()
//            : this(null, "serverVars")
//        {
//        }

//        private void Page_PreRenderComplete(object sender, EventArgs e)
//        {
//            this.RenderClientScript();
//        }

//        public void Add(string variableName, object value)
//        {
//            this.ScriptVariables.Add(variableName, value);
//        }

//        /// <summary>
//        /// Adds the dynamic value of a control or any object's property
//        /// that is picked up just before rendering. 
//        /// 
//        /// This allows you to specify a given control or object's value to 
//        /// added to the client object with the specified property value 
//        /// set on the JavaScript object and have that value be picked
//        /// up just before rendering. This is useful so you can do all
//        /// client object declarations up front in one place regardless
//        /// of where the values are actually set.
//        /// 
//        /// Dynamic values are retrieved with Reflection so this method
//        /// is necessarily slower than direct assignment.
//        /// </summary>
//        /// <param name="variableName"></param>
//        /// <param name="control"></param>
//        /// <param name="property"></param>
//        public void AddDynamicValue(string variableName, object control, string property)
//        {
//            // *** Special key syntax: .varName.Property syntax to be picked up by parser
//            this.ScriptVariables.Add("." + variableName + "." + property, control);
//        }

//        /// <summary>
//        /// Explicitly forces the client script to be rendered into the page.
//        /// This code is called automatically by the configured event handler that
//        /// is hooked to Page_PreRenderComplete
//        /// </summary>
//        private void RenderClientScript()
//        {
//            if (!this.AutoRenderClientScript || this.ScriptVariables.Count == 0)
//                return;

//            StringBuilder sb = new StringBuilder();
//            sb.AppendLine("var " + this.ClientObjectName + " = {");

//            // *** We'll serialize single values into the client
//            JavaScriptSerializer ser = new JavaScriptSerializer();
//            ser.MaxJsonLength = Int32.MaxValue;

//            foreach (KeyValuePair<string, object> entry in this.ScriptVariables)
//            {
//                if (entry.Key.StartsWith("."))
//                {
//                    // *** It's a dynamic key
//                    string[] tokens = entry.Key.Split(new char[1] { '.' }, StringSplitOptions.RemoveEmptyEntries);
//                    string varName = tokens[0];
//                    string property = tokens[1];


//                    object propertyValue = null;
//                    if (entry.Value != null)
//                        propertyValue = entry.Value.GetType().
//                                    GetProperty(property, BindingFlags.Instance | BindingFlags.Public).
//                                    GetValue(entry.Value, null);

//                    sb.AppendLine("\t\"" + varName + "\": " + ser.Serialize(propertyValue) + ",");
//                }
//                else
//                    sb.AppendLine("\t\"" + entry.Key + "\": " + ser.Serialize(entry.Value) + ",");
//            }

//            // *** Strip off last comma plus CRLF
//            if (sb.Length > 0)
//                sb.Length -= 3;

//            sb.AppendLine("\r\n}");

//            if (this.Page == null)
//                this.Page = HttpContext.Current.Handler as Page;

//            // *** Use ClientScriptProxy from West Wind Ajax Toolkit to be MS Ajax compatible - otherwise use ClientScript
//            this.Page.ClientScript.RegisterClientScriptBlock(typeof(scriptVariables), "_ClientScriptStrings", sb.ToString(), true);

//            //this.Page.ClientScript.RegisterClientScriptBlock(typeof(ControlResources), "_ClientScriptStrings", sb.ToString(), true);
//        }
//    }
//}