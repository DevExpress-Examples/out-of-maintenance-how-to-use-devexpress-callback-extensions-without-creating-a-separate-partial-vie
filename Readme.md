<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DynamicView/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DynamicView/Controllers/HomeController.vb))
* [DynamicPartial.cs](./CS/DynamicView/Helpers/DynamicPartial.cs) (VB: [DynamicPartial.vb](./VB/DynamicView/Helpers/DynamicPartial.vb))
* [GridHelper.cs](./CS/DynamicView/Helpers/GridHelper.cs) (VB: [GridHelper.vb](./VB/DynamicView/Helpers/GridHelper.vb))
* [Index.cshtml](./CS/DynamicView/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to use DevExpress callback extensions without creating a separate partial view


<p>This example demonstrates how to accomplish this task. To do so, a descendant of the PartialViewResult class is created. </p><p>Its ExecuteResult method is overridden to write our own MvcHtmlString object in response.</p>

<br/>


