Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Mvc.Html
Imports DevExpress.Web.Mvc
Imports DevExpress.Web.Mvc.UI

Namespace Q533692.Controllers
	Public Class DynamicPartial
        Inherits PartialViewResult

		Private privateModel As Object
		Private Property Model() As Object
			Get
				Return privateModel
			End Get
			Set(ByVal value As Object)
				privateModel = value
			End Set
		End Property

		Public Sub New()
		End Sub
        Public Sub New(ByVal passedModel As Object)
            Model = passedModel
        End Sub

		Public Overrides Sub ExecuteResult(ByVal context As ControllerContext)
			Dim response As HttpResponseBase = context.HttpContext.Response

			Dim Html = New HtmlHelper(New ViewContext(context, New FakeView(), context.Controller.ViewData, context.Controller.TempData, response.Output), New ViewPage())

			'it is possible to pass another content here based on some condition
			response.Write(GridHelper.GetGrid(Html,Model))
		End Sub

		Public Class FakeView
            Implements IView

            Public Sub Render(viewContext As ViewContext, writer As TextWriter) Implements IView.Render
                Throw New InvalidOperationException()
            End Sub
        End Class
	End Class
End Namespace