<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/230291165/19.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T848441)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DataSource for DevExtreme - How to implement CRUD operations with API controllers in an ASP.NET Core Razor Pages project

This example demonstrates how to bind DataGrid to a controller action and implement CRUD operations (such as Load, Insert, Update, and Delete) in a Razor Pages project.

Specify the Controller, LoadAction, UpdateAction, InsertAction, and DeleteAction properties so that the DataGrid's [DataSource](https://js.devexpress.com/DevExtreme/ApiReference/Data_Layer/DataSource/) can perform CRUD operations. In the corresponding controller, implement data operations in the actions.

Note that it is necessary to set up routing correctly in Razor Pages and controllers.

<!-- default file list -->
## Files to Review

- [DataGridEmployeesController.cs](./CS/CS/Controllers/DataGridEmployeesController.cs)
- [Index.cshtml](./CS/CS/Pages/Index.cshtml)

<!-- default file list end -->

## Documentation

- [Routing in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-3.1)
- [Data Source Examples](https://js.devexpress.com/DevExtreme/Guide/Data_Binding/Data_Source_Examples)

## More Examples

- [DataGrid - CRUD Operations Demo](https://demos.devexpress.com/ASPNetCore/Demo/DataGrid/CRUDOperations/)
- [DataGrid - How to utilize CRUD operations using the context menu](https://github.com/DevExpress-Examples/datagrid-how-to-utilize-crud-operations-using-the-context-menu-t123309)
