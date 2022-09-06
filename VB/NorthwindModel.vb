Imports System
Imports System.Collections.Generic
Imports T264297.NwindServiceReference

Namespace T264297

    Friend Class NorthwindModel

        Private context As NorthwindEntities = New NorthwindEntities(New Uri("http://services.odata.org/V3/Northwind/Northwind.svc"))

        Public Function Categories() As List(Of Category)
            Return context.Categories.Expand("Products").ToList()
        End Function
    End Class
End Namespace
