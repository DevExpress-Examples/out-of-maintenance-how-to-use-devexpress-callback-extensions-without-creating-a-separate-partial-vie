using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using DevExpress.Web.Mvc;
using DevExpress.Web.Mvc.UI;

namespace Q533692.Controllers {
    public class DynamicPartial : PartialViewResult {
        object Model { get; set; }

        public DynamicPartial() { }
        public DynamicPartial(object model) {
            Model = model;
        }

        public override void ExecuteResult(ControllerContext context) {
            HttpResponseBase response = context.HttpContext.Response;

            var Html = new HtmlHelper(
                new ViewContext(context, new FakeView(), context.Controller.ViewData, context.Controller.TempData, response.Output),
                new ViewPage());

            //it is possible to pass another content here based on some condition
            response.Write(GridHelper.GetGrid(Html,Model));
        }

        public class FakeView : IView {
            public void Render(ViewContext viewContext, TextWriter writer) {
                throw new InvalidOperationException();
            }
        }
    }
}