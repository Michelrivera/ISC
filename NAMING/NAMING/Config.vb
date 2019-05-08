Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Printing
Module Config
    Public connsql As SqlConnection
    Public Sub Iniciarconexion()
        connsql = New SqlConnection("Data Source=DESKTOP-2T50KML;Initial Catalog=NAMING;Integrated Security=True")
        connsql.Open()
    End Sub
End Module
