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

namespace ввод_символа_ASCLL
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string a;
        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if ((65 <= int.Parse(Txt.Text) & int.Parse(Txt.Text) <= 90) || (97 <= int.Parse(Txt.Text) & int.Parse(Txt.Text) <= 122))
                {
                    a = (Txt.Text);
                    TxtB.Text = "Получилась англ. буква - " + Encoding.GetEncoding(1251).GetString(new byte[] { Convert.ToByte(Txt.Text) })[0];
                }
                else
                    TxtB.Text = "Получилась не англ. буква, а что-то другое";
            }
            catch { TxtB.Text = "Введенны неправильные данные"; }

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
        }
    }
}
