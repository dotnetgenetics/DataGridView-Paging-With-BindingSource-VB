Option Infer On  
Imports System.Configuration  
Imports System.ComponentModel  
Imports System.Data
Imports System.Data.SqlClient

Public Class FDGVPaging
    Public Property TotalRecords() As Integer  
    Public Const PageSize = 10  
    Private sourceData As New List(Of String)  
    Private dtSource As New DataTable  

    'Public Sub New()  
    '     ' This call is required by the designer.  
    '     InitializeComponent()  
    '     ' Add any initialization after the InitializeComponent() call.  
    '          End Sub  

    Private Sub FDGVPaging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          Me.bindingNav.BindingSource = bindingProducts  
         AddHandler Me.bindingProducts.CurrentChanged, AddressOf Me.bindingProducts_CurrentChanged  
         SetSource()  
         bindingProducts.DataSource = new PageOffsetList

    End Sub

    Private Sub bindingProducts_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles bindingWebsite.CurrentChanged  
         Dim offset As Integer = CType(Me.bindingProducts.Current, Int32)  
         Dim records As New List(Of Record)  
         Dim i As Integer = offset  
         While i < offset + PageSize AndAlso i < TotalRecords  
           records.Add(New Record() With  
           { _  
             .ProductName = sourceData(i).ToString() _  
           })  
           i += 1  
         End While  

         dgvProductNames.DataSource = records  

       End Sub  

    Private Sub SetSource()  
         Dim sql As String = "select [Name] as ProductName from [Production].[Product] order by [Name] asc;"  
         Dim conn As SqlConnection  
         conn = Nothing  
         Try  
           Dim connection As String = ConfigurationManager.AppSettings("AdventureWorks").ToString()  
           conn = New SqlConnection(connection)  
           conn.Open()  
           Dim cmd As New SqlCommand(sql, conn)  
           Dim da As New SqlDataAdapter(cmd)  
           da.Fill(dtSource)  
           If dtSource.Rows.Count Then  
             For Each item As DataRow In dtSource.Rows  
               If Not String.IsNullOrEmpty(item(0).ToString()) Then  
                 sourceData.Add(item(0).ToString())  
               End If  
             Next  
           End If  
           TotalRecords = sourceData.Count  
           conn.Close()  
         Catch ex As Exception  
           conn.Close()  
           conn.Dispose()  
         End Try  
       End Sub  
End Class
