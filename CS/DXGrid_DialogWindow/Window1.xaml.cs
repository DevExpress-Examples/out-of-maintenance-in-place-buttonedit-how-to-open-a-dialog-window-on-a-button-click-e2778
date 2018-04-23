using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace DXGrid_DialogWindow {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            gridControl1.DataSource = GetData();
        }

        private List<GridDataObject> GetData() {
            List<GridDataObject> list = new List<GridDataObject>();
            list.Add(new GridDataObject() { Value1 = "A", Value2 = 1 });
            list.Add(new GridDataObject() { Value1 = "B", Value2 = 2 });
            list.Add(new GridDataObject() { Value1 = "C", Value2 = 3 });
            return list;
        }
    }

    public class GridDataObject {
        public string Value1 { get; set; }
        public int Value2 { get; set; }
    }
}
