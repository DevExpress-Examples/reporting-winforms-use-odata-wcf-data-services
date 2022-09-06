<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T264297)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [NorthwindModel.cs](./CS/NorthwindModel.cs) (VB: [NorthwindModel.vb](./VB/NorthwindModel.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [Reference.cs](./CS/Service%20References/NwindServiceReference/Reference.cs) (VB: [Reference.vb](./VB/Service%20References/NwindServiceReference/Reference.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to use OData (WCF Data Services) to provide data for a report


At the moment, XtraReports cannot connect to an OData data source directly. <br><br>Our reporting tools, however, are data source agnostic and support data sources of different types including .NET data providers, lists (implementing the System.Collections.IList, System.ComponentModel.ITypedList, or System.ComponentModel.IBindingList interface), and XML data sources. To learn more, refer to <a href="https://documentation.devexpress.com/XtraReports/CustomDocument1179.aspx">Data Binding Approaches</a>.<br><br>So, to provide report data through the OData service, get IList data from the OData Service and then pass it to a report. Here are implementation details.<br><br>1. Add the OData Service Reference to your project. Now, the OData service context is registered in the application. See the <a href="http://www.asp.net/web-api/overview/odata-support-in-aspnet-web-api/odata-v3/calling-an-odata-service-from-a-net-client">Calling an OData Service From a .NET Client (C#)</a> article for details.<br>2. Create a data model from the OData Service context. This data model will retrieve data from the OData service and return IList data. <br>
<p>Please note that OData defines <a href="http://www.asp.net/web-api/overview/odata-support-in-aspnet-web-api/supporting-odata-query-options">query options</a> that can be used to filter, sort, page data, and so forth. For more details, see the <a href="http://msdn.microsoft.com/en-us/library/ee622463.aspx">LINQ Considerations (WCF Data Services)</a> topic on MSDN.</p>
<p>3. Bind a report to this data model through the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17784">ObjectDataSource </a>component. Please note that it is necessary to retrieve actual data from a custom object data source. Please refer to <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17784/ActualData">Retrieve the Actual Data</a>.<br><br>See also:<br><a href="https://www.devexpress.com/Support/Center/p/E282">Using the Web Service as an XtraReport.DataSource</a><br><a href="https://www.devexpress.com/Support/Center/p/E4291">How to use WCF ReportService in WPF</a></p>

<br/>


