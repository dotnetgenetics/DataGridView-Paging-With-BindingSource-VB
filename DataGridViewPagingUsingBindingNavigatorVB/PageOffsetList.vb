Option Infer On  
Imports System.ComponentModel  

 Public Class PageOffsetList  
   Implements IListSource  

   Public ReadOnly Property ContainsListCollection() As Boolean _  
     Implements System.ComponentModel.IListSource.ContainsListCollection  
     Get  
       Return False  
     End Get  
   End Property  

   Public Function GetList() As System.Collections.IList _  
     Implements System.ComponentModel.IListSource.GetList  
     Dim pageOffset As New List(Of Int32)  
     Dim offset As Integer = 0  
     While offset <= FDGVPaging.TotalRecords  
       pageOffset.Add(offset)  
       offset = offset + FDGVPaging.PageSize  
     End While  
     Return pageOffset  
   End Function  
 End Class 