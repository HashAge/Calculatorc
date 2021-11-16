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

namespace RPNCalc
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
        public struct storage{
            public float y, x, choice;
            public bool check;
                      
        };
        storage s = new storage();
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == btn_0) tbx_a.Text += '0';
            if (e.Source == btn_1) tbx_a.Text += '1';
            if (e.Source == btn_2) tbx_a.Text += '2';
            if (e.Source == btn_3) tbx_a.Text += '3';
            if (e.Source == btn_4) tbx_a.Text += '4';
            if (e.Source == btn_5) tbx_a.Text += '5';
            if (e.Source == btn_6) tbx_a.Text += '6';
            if (e.Source == btn_7) tbx_a.Text += '7';
            if (e.Source == btn_8) tbx_a.Text += '8';
            if (e.Source == btn_9) tbx_a.Text += '9';
        }
        private void btns_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source == btn_dec && float.TryParse(tbx_a.Text,out float a) == true)
            {
                s.x = float.Parse(tbx_a.Text.Replace("-", ""));
                s.check = true;
                s.choice = 1;
                tbx_a.Clear();
            }
            if (e.Source == btn_inc && float.TryParse(tbx_a.Text,out float b) == true)
            {
                s.x = float.Parse(tbx_a.Text.Replace("+", ""));
                s.check = true;
                s.choice = 2;
                tbx_a.Clear();
            }
            if (e.Source == btn_div && float.TryParse(tbx_a.Text,out float v) == true)
            { 
                s.x = float.Parse(tbx_a.Text.Replace("/", ""));            
                s.check = true;
                s.choice = 3;
                tbx_a.Clear();
            }
            if (e.Source == btn_mul && float.TryParse(tbx_a.Text,out float z) == true)
            {
                s.x = float.Parse(tbx_a.Text.Replace("*", ""));             
                s.check = true;
                s.choice = 4;
                tbx_a.Clear();
            }
            if(e.Source == btn_nxt && float.TryParse(tbx_a.Text, out float j) == true && s.check == true)
            {
                switch (s.choice)
                {
                    case 1: s.y = s.x - float.Parse(tbx_a.Text);break;
                    case 2: s.y = s.x + float.Parse(tbx_a.Text);break;
                    case 3: s.y = s.x / float.Parse(tbx_a.Text);break;
                    case 4: s.y = s.x * float.Parse(tbx_a.Text);break;
                }
                tbx_a.Text = null;
                tbx_a.Text += s.y;
                s.y = 0;
                s.x = 0;
            }
            if (e.Source == btn_clr) tbx_a.Clear();
        }
        }
    }  

