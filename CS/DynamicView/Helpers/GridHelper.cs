using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.Web.Mvc.UI;

namespace Q533692.Controllers {
    public static class GridHelper {

        public static MvcHtmlString GetGrid(HtmlHelper html, object Model) {
            var grid = new GridViewExtension(GetSettings(html), html.ViewContext).Bind(Model).GetHtml();
            return grid;
        }
        private static GridViewSettings GetSettings(HtmlHelper html) {
            var settings = new GridViewSettings();
            settings.Name = "gridView";
            settings.CallbackRouteValues = new { Controller = "Home", Action = "GridViewPartial" };

            settings.Columns.Add("ID");
            settings.Columns.Add("Text").SetDataItemTemplateContent(c => {
                html.ViewContext.Writer.Write("<div style='background-color:yellow;'>");
                html.ViewContext.Writer.Write("test string");
                html.ViewContext.Writer.Write("</div>");
                html.DevExpress().TextBox(tbSettings => {
                    tbSettings.Name = "tb" + c.VisibleIndex;
                    tbSettings.Text = c.Text;
                }).Render();
            });
            return settings;
        }
    }
}