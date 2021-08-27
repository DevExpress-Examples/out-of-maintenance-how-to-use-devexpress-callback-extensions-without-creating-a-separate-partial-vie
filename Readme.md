<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128566971/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5027)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DynamicView/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DynamicView/Controllers/HomeController.vb))
* [DynamicPartial.cs](./CS/DynamicView/Helpers/DynamicPartial.cs) (VB: [DynamicPartial.vb](./VB/DynamicView/Helpers/DynamicPartial.vb))
* [GridHelper.cs](./CS/DynamicView/Helpers/GridHelper.cs) (VB: [GridHelper.vb](./VB/DynamicView/Helpers/GridHelper.vb))
* [Index.cshtml](./CS/DynamicView/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to use DevExpress callback extensions without creating a separate partial view
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5027)**
<!-- run online end -->


<p>This example demonstrates how to accomplish this task. To do so, a descendant of the PartialViewResult class is created. </p><p>Its ExecuteResult method is overridden to write our own MvcHtmlString object in response.</p>

<br/>


