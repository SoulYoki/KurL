using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chest
{
    /// <summary>
    /// Interaction logic for DataGrid.xaml
    /// </summary>
    public partial class DataGrid : Window
    {
        public DataGrid(int idn)
        {
            InitializeComponent();
            DataContext = this;
            DataGridTable.ItemsSource = SourceCore.MyBase.Chesters.Where(q => q.ID_Category.Equals(idn)).ToList();
        }
    }
}
