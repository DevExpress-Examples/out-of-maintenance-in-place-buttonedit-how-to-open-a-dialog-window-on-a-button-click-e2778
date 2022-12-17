Imports System
Imports System.Windows

Namespace DXGrid_DialogWindow

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.DataSource = New ProductList()
        End Sub

        Private Sub ButtonEditSettings_DefaultButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dispatcher.BeginInvoke(New Action(AddressOf ShowWindow))
        End Sub

        Private Sub ShowWindow()
            Dim wind As Window1 = New Window1()
            wind.ShowDialog()
        End Sub
    End Class
End Namespace
