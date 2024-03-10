<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T264297)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for WinForms - How to Use OData (WCF Data Services) as the Report Data Source

This example gets data from the OData service with the [DataServiceQuery](https://docs.microsoft.com/en-us/dotnet/api/system.data.services.client.dataservicequery) as `IEnumerable<T>`. The report is bound to data through the [ObjectDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.ObjectBinding.ObjectDataSource) component.

![Report Bound to OData (WCF Data Services)](Images/screenshot.png)

## Files to Review

* [NorthwindModel.cs](./CS/NorthwindModel.cs)
* [XtraReport1.Designer.cs](./CS/XtraReport1.Designer.cs)

## Documentation

- [Bind Reports to Data](https://docs.devexpress.com/XtraReports/15034/detailed-guide-to-devexpress-reporting/bind-reports-to-data)
- [Getting Started with OData Client](https://docs.microsoft.com/en-us/odata/client/getting-started)





