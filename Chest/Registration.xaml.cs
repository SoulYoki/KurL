using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private Base.ChestEntities DataBase;
        public Registration(Base.ChestEntities Database)
        {
            InitializeComponent();
            this.DataBase = Database;
        }

      

        private void PasswordButton_Click(object sender, RoutedEventArgs e)
        {
            // Переброска необходимой информации во временные буферы
            String Password = PasswordPasswordBox.Password;
            Visibility Visibility = PasswordPasswordBox.Visibility;
            double Width = PasswordPasswordBox.ActualWidth;
            // Изменение подписи на кнопке
            PasswordButton.Content = Visibility == Visibility.Visible ? "Скрыть" : "Показать";
            // Переброска информации из TextBox'а в PasswordBox
            PasswordPasswordBox.Password = PasswordTextBox.Text;
            PasswordPasswordBox.Visibility = PasswordTextBox.Visibility;
            PasswordPasswordBox.Width = PasswordTextBox.Width;
            // Возврат информации из временных буферов в TextBox
            PasswordTextBox.Text = Password;
            PasswordTextBox.Visibility = Visibility;
            PasswordTextBox.Width = Width;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

            // Создание и инициализация нового пользователя системы
          // String password = PasswordPasswordBox.Password != "" ? CheckPassword(PasswordPasswordBox.Password) : CheckPassword(PasswordTextBox.Text);
            if (textBox1.Text == Checer.Text)
            {
                Base.Users User = new Base.Users();
                User.Логин = LoginTextBox.Text;
                User.Пароль = PasswordPasswordBox.Password != "" ? PasswordPasswordBox.Password : PasswordTextBox.Text;
               // User.ID_Users = Int32.Parse(IDTextBox.Text);
                // Добавление его в базу данных
                DataBase.Users.Add(User);
                // Сохранение изменений
                DataBase.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Puk", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            };
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            {
                String allowchar = " ";
                allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
                allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
                allowchar += "1,2,3,4,5,6,7,8,9,0";
                //разделитель
                char[] a = { ',' };
                //расщепление массива по разделителю
                String[] ar = allowchar.Split(a);
                String pwd = " ";
                string temp = " ";
                Random r = new Random();
                for (int i = 0; i < 6; i++)
                {
                    temp = ar[(r.Next(0, ar.Length))];
                    pwd += temp;
                }
                textBox1.Text = pwd;
            }

        }
    }
}
