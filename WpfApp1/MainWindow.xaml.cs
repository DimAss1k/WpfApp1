﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        bool Choised = false;
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
   //     Window1 workWindow = new Window1();
        private void bRegistration_Click(object sender, RoutedEventArgs
        e)
        {
            Choised = false;
            tbLogin.IsEnabled = true;
            tbPass1.IsEnabled = true;
            tbPass2.IsEnabled = true;
            bEnter.IsEnabled = true;
        }
        private void bLogin_Click(object sender, RoutedEventArgs e)
        {
            Choised = true;
            tbLogin.IsEnabled = true;
            tbPass1.IsEnabled = true;
            tbPass2.IsEnabled = false;
            bEnter.IsEnabled = true;
        }
        private void Registration(string tbL, string tbP1, string tbP2)
        {
            Window1 workWindow = new Window1();
            if (tbL == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (tbP1 == tbP2)
            {
                /*
                проверить логин на незанятость если такого нет
               зарегистрировать пользователя, иначе сообщить об ошибке
                */
            }
            else
            {
                MessageBox.Show("Пароли различны");
                return;
            }
            workWindow.lUser.Content = "Текущий пользователь: " +
           tbL;
            workWindow.Show();
            Close();
        }
        private void Logining(string tbL, string tbP1)
        {
            Window1 workWindow = new Window1();
            if (tbL == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            /*
            Добавить проверку логина и пароля из БД если они
           верны пустить дальше, иначе сообщить об ошибке
            */
            workWindow.lUser.Content = "Текущий пользователь:" + tbL;
            workWindow.Show();
            Close();
        }
        private void bEnter_Click(object sender, RoutedEventArgs e)
        {
            if (Choised == false)
            {
                Registration(tbLogin.Text, tbPass1.Text,
               tbPass2.Text);
            }
            else
            {
                Logining(tbLogin.Text, tbPass1.Text);
            }
        }
    }
}