Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports DevExpress.Web.Mvc.UI

Namespace Q533692.Controllers
	Public NotInheritable Class GridHelper

		Private Sub New()
		End Sub
		Public Shared Function GetGrid(ByVal html As HtmlHelper, ByVal Model As Object) As MvcHtmlString
			Dim grid = New GridViewExtension(GetSettings(html)).Bind(Model).GetHtml()
			Return grid
		End Function
		Private Shared Function GetSettings(ByVal html As HtmlHelper) As GridViewSettings
			Dim settings = New GridViewSettings()
			settings.Name = "gridView"
			settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}

			settings.Columns.Add("ID")
            settings.Columns.Add("Text").SetDataItemTemplateContent(Sub(c)
                                                                        html.ViewContext.Writer.Write("<div style='background-color:yellow;'>")
                                                                        html.ViewContext.Writer.Write("test string")
                                                                        html.ViewContext.Writer.Write("</div>")
                                                                        html.DevExpress().TextBox(Sub(tbSettings)
                                                                                                      tbSettings.Name = "tb" & c.VisibleIndex
                                                                                                      tbSettings.Text = c.Text
                                                                                                  End Sub).Render()
                                                                    End Sub)
			Return settings
		End Function
	End Class
End Namespace