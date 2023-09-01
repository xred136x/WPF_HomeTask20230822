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

namespace WPF_HomeTask20230822
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //addButton();
        }
        private void addButton()
        {
          
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Button> buttons = new List<Button> {Button1, Button2, Button3, Button4, Button5,
            Button6, Button7, Button8, Button9, Button10, Button11, Button12, Button13, 
            Button14, Button15, Button16};
            
           

        }
    }
}
