using System;
using System.Windows;

namespace DXGrid_DialogWindow {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.DataSource = new ProductList();
        }

        private void ButtonEditSettings_DefaultButtonClick(object sender, RoutedEventArgs e) {
            Dispatcher.BeginInvoke(new Action(ShowWindow));
        }

        void ShowWindow() {
            Window1 wind = new Window1();
            wind.ShowDialog();
        }
    }
}
