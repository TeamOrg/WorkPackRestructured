using System;
using System.Collections.Generic;
using System.Linq;



namespace CommonLibrary
{
    //[
    //ToolboxData("<{0}:ExGridView runat=\"server\"> </{0}:ExGridView>")
    //]
    //public class ExGridView : GridView
    //{

    //    public ExGridView() { }

    //    public Unit GridHeight { get; set; }

    //    private String CalculateWidth()
    //    {
    //        string strWidth = "auto";
    //        if (!this.Width.IsEmpty)
    //        {
    //            strWidth = String.Format("{0}{1}", this.Width.Value, ((this.Width.Type == UnitType.Percentage) ? "%" : "px"));
    //        }
    //        return strWidth;
    //    }

    //    private String CalculateHeight()
    //    {
    //        string strHeight = "200px";
    //        if (!this.GridHeight.IsEmpty)
    //        {
    //            strHeight = String.Format("{0}{1}", this.GridHeight.Value, ((this.GridHeight.Type == UnitType.Percentage) ? "%" : "px"));
    //        }
    //        return strHeight;
    //    }

    //    protected override void Render(HtmlTextWriter writer)
    //    {
    //        //render header row 
    //        writer.Write("<table  border='0' cellspacing='" + this.CellSpacing.ToString() + "' cellpadding='" + this.CellPadding.ToString() + "' style='max-width: none;width:" + CalculateWidth() + ";'>");
    //        GridViewRow customHeader = this.HeaderRow;

    //        if (this.HeaderRow != null)
    //        {
    //            customHeader.ApplyStyle(this.HeaderStyle);
    //            if (AutoGenerateColumns == false)
    //            {
    //                int i = 0;
    //                foreach (DataControlField col in this.Columns)
    //                {
    //                    customHeader.Cells[i].ApplyStyle(col.HeaderStyle);
    //                    customHeader.Cells[i].Style.Add("background", "repeat-x scroll center top #424242");
    //                    customHeader.Cells[i].Style.Add("font-family", "Verdana");
    //                    customHeader.Cells[i].Style.Add("font-size", "10px");
    //                    customHeader.Cells[i].Style.Add("font-weight", "normal");
    //                    customHeader.Cells[i].Style.Add("color", "#FFFFFF");
    //                    customHeader.Cells[i].Style.Add("border-left", "1px solid #525252");
    //                    customHeader.Cells[i].Style.Add("padding", "4px 2px");
    //                    //background: repeat-x scroll center top #424242;font-family: Verdana;font-size: 10px;font-weight: normal;border-left: 1px solid #525252;color: #FFFFFF;
    //                    if (!col.Visible)
    //                    {
    //                        customHeader.Cells[i].Text = "";
    //                        customHeader.Cells[i].Style.Add("padding", "0px 0px");
    //                        customHeader.Cells[i].Style.Add("width", "0px");
    //                        customHeader.Cells[i].Style.Add("border-left", "0px solid #525252");
    //                    }
    //                    i++;
    //                }

    //            }

    //            customHeader.RenderControl(writer);
    //            this.HeaderRow.Visible = false;


    //        }
    //        writer.Write("</table>");

    //        //render data rows
    //        writer.Write("<div id='" + ClientID + "_div'  style='" +
    //                         "padding-bottom:5px;overflow-x:hidden;overflow-y:scroll;" +

    //                         "width:" + CalculateWidth() + ";" +
    //                         "height:" + CalculateHeight() + ";" +
    //                         "background-color:#FFFFFF;'>");

    //        //get the pager row and make invisible
    //        GridViewRow customPager = this.BottomPagerRow;
    //        if (this.BottomPagerRow != null)
    //        {
    //            //this.BottomPagerRow.Visible = false;
    //        }


    //        base.Render(writer);
    //        writer.Write("</div>");

    //        //render pager row
    //        //if (customPager != null && this.PageCount > 0)
    //        //{
    //        //    writer.Write("<table  border='0' cellspacing='" + this.CellSpacing.ToString() + "' cellpadding='" + this.CellPadding.ToString() + "' style='width:" + CalculateWidth() + "'>");
    //        //    customPager.ApplyStyle(this.PagerStyle);
    //        //    customPager.Visible = true;
    //        //    customPager.RenderControl(writer);
    //        //    writer.Write("</table>");
    //        //}


    //    }
    //}

}