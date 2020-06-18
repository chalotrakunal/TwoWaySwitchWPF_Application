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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool GetSwitch1LabelValue()
        {
            bool switch1Value= Convert.ToBoolean(Convert.ToInt32(button1.Content.ToString()));
            return switch1Value;
        }
        private bool GetSwitch2LabelValue()
        {
            bool switch2Value = Convert.ToBoolean(Convert.ToInt32(button2.Content.ToString()));
            return switch2Value;
        }
        private void LightBulbOnOff(bool switch1Value, bool switch2Value)
        {
            bool isOnOff = switch1Value && switch2Value || !switch1Value && !switch2Value;    // XNOR logic Gate
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            if(isOnOff)
            {
                mySolidColorBrush.Color = Color.FromRgb(255, 255, 0);
                ellipse.Fill = mySolidColorBrush;
            }
            else
            {
                mySolidColorBrush.Color = Color.FromRgb(255, 255, 255);
                ellipse.Fill = mySolidColorBrush;
            }
        }
        private void ToggleButtonFunctionality(Button buttonName)
        {
            if (buttonName.Content.ToString() == "1")
            {
                buttonName.Content = "0";
                LightBulbOnOff(GetSwitch1LabelValue(), GetSwitch2LabelValue());
            }
            else
            {
                buttonName.Content = "1";
                LightBulbOnOff(GetSwitch1LabelValue(), GetSwitch2LabelValue());
            }
        }
        private void Switch1(object sender, RoutedEventArgs e)
        {
            ToggleButtonFunctionality(button1);
        }
        private void Switch2(object sender, RoutedEventArgs e)
        {
            ToggleButtonFunctionality(button2);
        }
    }
}
