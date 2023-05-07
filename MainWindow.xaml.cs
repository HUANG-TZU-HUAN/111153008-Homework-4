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

namespace _111153008_Homework_4
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void zero(string _one)
        {
            if(txtNumber.Text=="0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text+= _one;
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            zero("1");
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            zero("2");
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            zero("3");
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            zero("4");
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            zero("5");
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            zero("6");
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            zero("7");
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            zero("8");
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            zero("9");
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            zero("0");
        }

        void AMPD(string amp) 
        { 
            double first;
            first = Convert.ToDouble(txtNumber.Text);
            txtNumber.Text = "0";
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
