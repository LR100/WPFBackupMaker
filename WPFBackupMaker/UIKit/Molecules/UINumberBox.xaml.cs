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
using static System.Net.Mime.MediaTypeNames;

namespace WPFBackupMaker.UIKit
{
    /// <summary>
    /// Interaction logic for UINumberBox.xaml
    /// </summary>
    public partial class UINumberBox : System.Windows.Controls.UserControl
    {
        private const int PrecisionDecimal = 10;

        public UINumberBox()
        {
            Minimum = double.MinValue;
            Maximum = double.MaxValue;
            Step = 1.0; // By Default step of 1
            InitializeComponent();    
        }

        // Minimum value (double) for the number box
        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }
        public static readonly System.Windows.DependencyProperty MinimumProperty =
            System.Windows.DependencyProperty.Register("Minimum", typeof(double), typeof(UINumberBox), new System.Windows.PropertyMetadata(0.0));

        // Maximum value (double) for the number box
        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }
        public static readonly System.Windows.DependencyProperty MaximumProperty =
            System.Windows.DependencyProperty.Register("Maximum", typeof(double), typeof(UINumberBox), new System.Windows.PropertyMetadata(100.0));

        // Step value (double) for the number box
        public double Step
        {
            get { return (double)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }
        public static readonly System.Windows.DependencyProperty StepProperty =
            System.Windows.DependencyProperty.Register("Step", typeof(double), typeof(UINumberBox), new System.Windows.PropertyMetadata(1.0));

        // On Plus button click
        private void OnPlusButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            double value = double.TryParse(NumberBoxTextBoxInput.Text, out double result) ? result : 0;
            if (value < Maximum)
            {
                value += Step;
                value = Math.Round(value, PrecisionDecimal);
                NumberBoxTextBoxInput.Text = value.ToString();
            }
        }

        // On Minus button click
        private void OnMinusButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            double value = double.TryParse(NumberBoxTextBoxInput.Text, out double result) ? result : 0;
            if (value > Minimum)
            {
                value -= Step;
                value = Math.Round(value, PrecisionDecimal);
                NumberBoxTextBoxInput.Text = value.ToString();
            }
        }
    }
}
 