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

        int intswitch;
        double first;
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

        void AMPD(int amp) 
        { 
            first = Convert.ToDouble(txtNumber.Text);
            txtNumber.Text = "0";
            intswitch = amp;
        }



        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AMPD(0);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            AMPD(1);
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            AMPD(2);
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            AMPD(3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text.IndexOf(".") == -1)
            {
                txtNumber.Text += ".";
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double second,ans=0;
            if(double.TryParse(txtNumber.Text,out second)==true)
            {
                switch (intswitch)
                {
                    case 0:
                        ans = first + second;
                        break;
                    case 1:
                        ans = first - second;
                        break;
                    case 2:
                        ans= first * second;
                        break;
                    case 3:
                        ans= first / second;
                        break;
                }
                txtNumber.Text=string.Format("{0:0.#####}",ans);
                intswitch= -1;
                ans= 0;
                first= 0;
                second= 0;
            }
        }

        private void btnClear_Click_1(object sender, RoutedEventArgs e)
        {
            txtNumber.Text = "0";
            intswitch = -1;
            first = 0;
        }

        private void ___Click(object sender, RoutedEventArgs e)
        {
            double a;
            if(double.TryParse(txtNumber.Text,out a) == true)
            {
                txtNumber.Text = string.Format("{0:0.#####}", a / 100);
            }
        }

        private void btnbs_Click(object sender, RoutedEventArgs e)
        {
            if(txtNumber.Text.Length>0) 
            {
            txtNumber.Text=txtNumber.Text.Remove(txtNumber.Text.Length-1,1);
            }
        }
    }
}
