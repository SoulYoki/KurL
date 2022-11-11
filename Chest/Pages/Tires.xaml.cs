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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chest.Pages
{
    /// <summary>
    /// Interaction logic for Tires.xaml
    /// </summary>
    public partial class Tires : Page
    {
        public Tires()
        {
            InitializeComponent();
            DataContext = this;
            TiresPage.ItemsSource = SourceCore.MyBase.Chesters.ToList();
        }
    }
}
