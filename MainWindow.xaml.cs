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

namespace wpf_hw_one
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Синий цвет показывает тюркское происхождение азербайджанского народа.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Красный цвет отражает желание построить современное общество, развивать демократию. Полумесяц на флаге символизировал ислам, а восьмиконечная звезда, по Фатали Хану Хойскому, указывает на 8 букв названия «Азербайджан» (арабским алфавитом).");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зеленый цвет указывает на принадлежность к исламской цивилизации.");
        }
    }
}
