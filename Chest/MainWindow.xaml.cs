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
using Chest.Base;


namespace Chest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            categorysList.ItemsSource = SourceCore.MyBase.Categorys.ToList();
            
        }
       //public partial class Categor : Page
       // {
       //     private int _BlockNum = 1;
            
            
       //     public int BlockNum
       //     {
       //         get
       //         {
       //             return _BlockNum;
       //         }
       //         set
       //         {
       //             if (value <= 0)
       //             {
       //                 value = 1;
       //             }
       //             else
       //             {
                     

       //             }

       //         }
       //     }


        //}


        private void categorysList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Categorys p = (Categorys)categorysList.SelectedItem;
            //MessageBox.Show(p.Наименование);
            int idn = p.ID_Categorys;
            DataGrid window = new DataGrid(idn);
            window.Show();
           
        }
    }
}
