Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents

Namespace DXGrid_DialogWindow
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = GetData()
		End Sub

		Private Function GetData() As List(Of GridDataObject)
			Dim list As New List(Of GridDataObject)()
			list.Add(New GridDataObject() With {.Value1 = "A", .Value2 = 1})
			list.Add(New GridDataObject() With {.Value1 = "B", .Value2 = 2})
			list.Add(New GridDataObject() With {.Value1 = "C", .Value2 = 3})
			Return list
		End Function
	End Class

	Public Class GridDataObject
		Private privateValue1 As String
		Public Property Value1() As String
			Get
				Return privateValue1
			End Get
			Set(ByVal value As String)
				privateValue1 = value
			End Set
		End Property
		Private privateValue2 As Integer
		Public Property Value2() As Integer
			Get
				Return privateValue2
			End Get
			Set(ByVal value As Integer)
				privateValue2 = value
			End Set
		End Property
	End Class
End Namespace
