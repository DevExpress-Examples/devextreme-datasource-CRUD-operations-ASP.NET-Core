<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/230291165/19.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T848441)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DataSource for DevExtreme - How to implement CRUD operations with API controllers in ASP.NET Core in a Razor Pages project

This example demonstrates how to bind DataGrid to a controller action and implement [CRUD](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete) operations in a Razor Pages project.

Specify the Controller, LoadAction, UpdateAction, InsertAction and DeleteAction properties so that DataGrid's [DataSource](https://js.devexpress.com/DevExtreme/ApiReference/Data_Layer/DataSource/) can perform CRUD operations. In the corresponding controller, implement data operations in the actions.

Note that it is necessary to correctly setup routing in Razor Pages and controllers.

<!-- default file list -->
## Files to Look At

- [DataGridEmployeesController.cs](./CS/CS/Controllers/DataGridEmployeesController.cs)
- [Index.cshtml](./CS/CS/Pages/Index.cshtml)

<!-- default file list end -->

## Documentation

- [Routing in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-3.1)
- [Data Source Examples](https://js.devexpress.com/DevExtreme/Guide/Data_Binding/Data_Source_Examples/#Custom_Sources)

## More Examples

- [DataGrid - How to implement a context menu for editing, adding and deleting rows](https://github.com/DevExpress-Examples/datagrid-how-to-utilize-crud-operations-using-the-context-menu-t123309)