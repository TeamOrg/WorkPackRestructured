namespace CommonLibrary
{
    //public class BasePage : System.Web.UI.Page
    //{
    //    public static string networkdirectorypath = ConfigurationSettings.AppSettings["FileServerPath"];
    //    public static string GetFileServerPath = ConfigurationSettings.AppSettings["GetFileServerPath"];
    //    public static string Body = "";
    //    public static string checker = "";
    //    public static string sender = "";
    //    public static string SenderUserName = "";        
    //    public static string subject = "";
    //    public static string Attachment = "";
    //    public static string SqlJobServer = ConfigurationSettings.AppSettings["SqlServerName"];
    //    public static string SqlJobDB = ConfigurationSettings.AppSettings["SqlServerJabEcecutiobDB"];



    //    #region "Page Load"
    //    private void Page_Load(object sender, System.EventArgs e)
    //    {
    //        GeneralFuntions.AddNoCache();
    //    }
    //    public BasePage()
    //    {
    //        Load += Page_Load;
    //    }
    //    private bool m_RefreshState;
    //    private bool m_IsRefresh;

    //    public bool IsRefresh
    //    {
    //        get
    //        {
    //            return m_IsRefresh;
    //        }
    //    }


    //    /// <summary>
    //    /// Restores view-state information from a previous page request that was saved by the <see cref="M:System.Web.UI.Control.SaveViewState"/> method.
    //    /// Code for browser refresh issue
    //    /// </summary>
    //    /// <param name="savedState">An <see cref="T:System.Object"/> that represents the control state to be restored.</param>
    //    protected override void LoadViewState(object savedState)
    //    {
    //        object[] allStates = (object[])savedState;
    //        base.LoadViewState(allStates[0]);
    //        m_RefreshState = (bool)allStates[1];
    //        //Added By Bhavana 
    //        if (Session["__ISREFRESH"] != null)
    //            m_IsRefresh = m_RefreshState == (bool)Session["__ISREFRESH"];
    //    }
    //    /// <summary>
    //    /// Saves any server control view-state changes that have occurred since the time the page was posted back to the server.
    //    /// </summary>
    //    /// <returns>
    //    /// Returns the server control's current view state. If there is no view state associated with the control, this method returns null.
    //    /// </returns>
    //    protected override object SaveViewState()
    //    {
    //        Session["__ISREFRESH"] = m_RefreshState;
    //        object[] allStates = new object[2];
    //        allStates[0] = base.SaveViewState();
    //        allStates[1] = !m_RefreshState;
    //        return allStates;
    //    }


    //    #endregion

    //}
}
