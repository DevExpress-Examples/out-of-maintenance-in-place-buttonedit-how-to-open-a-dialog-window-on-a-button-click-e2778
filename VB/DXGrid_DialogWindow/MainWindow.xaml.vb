Imports Microsoft.VisualBasic
Imports System
Imports System.Windows

Namespace DXGrid_DialogWindow
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New ProductList()
		End Sub

		Private Sub ButtonEditSettings_DefaultButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dispatcher.BeginInvoke(New Action(AddressOf ShowWindow))
		End Sub

		Private Sub ShowWindow()
			Dim wind As New Window1()
			wind.ShowDialog()
		End Sub
	End Class
End Namespace
