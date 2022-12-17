Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents

Namespace DXGrid_DialogWindow

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.gridControl1.DataSource = GetData()
        End Sub

        Private Function GetData() As List(Of GridDataObject)
            Dim list As List(Of GridDataObject) = New List(Of GridDataObject)()
            list.Add(New GridDataObject() With {.Value1 = "A", .Value2 = 1})
            list.Add(New GridDataObject() With {.Value1 = "B", .Value2 = 2})
            list.Add(New GridDataObject() With {.Value1 = "C", .Value2 = 3})
            Return list
        End Function
    End Class

    Public Class GridDataObject

        Public Property Value1 As String

        Public Property Value2 As Integer
    End Class
End Namespace
