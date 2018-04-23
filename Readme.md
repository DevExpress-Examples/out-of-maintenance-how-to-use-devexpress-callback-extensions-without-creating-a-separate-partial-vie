# How to use DevExpress callback extensions without creating a separate partial view


<p>This example demonstrates how to accomplish this task. To do so, a descendant of the PartialViewResult class is created. </p><p>Its ExecuteResult method is overridden to write our own MvcHtmlString object in response.</p>

<br/>


