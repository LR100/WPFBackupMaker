
using System.Windows.Controls;
using UserControl = System.Windows.Controls.UserControl;
// Keep UIKit namespace to make all the UI components available with one using statement in xaml
namespace WPFBackupMaker.UIKit
{
    /// <summary>
    /// Interaction logic for UIHeader.xaml
    /// </summary>
    // Set the HeaderContent property as ContentProperty
    [System.Windows.Markup.ContentProperty("HeaderContent")]
    public partial class UIHeader : UserControl
    {
        public UIHeader()
        {
            InitializeComponent();
        }

        // Header Text
        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }
        public static readonly System.Windows.DependencyProperty HeaderTextProperty =
            System.Windows.DependencyProperty.Register("HeaderText", typeof(string), typeof(UIHeader), new System.Windows.PropertyMetadata("Header Text"));

        // Header Icon
        public System.Windows.Media.ImageSource? HeaderIcon
        {
            get { return (System.Windows.Media.ImageSource)GetValue(HeaderIconProperty); }
            set { SetValue(HeaderIconProperty, value); }
        }
        public static readonly System.Windows.DependencyProperty HeaderIconProperty =
            System.Windows.DependencyProperty.Register("HeaderIcon", typeof(System.Windows.Media.ImageSource), typeof(UIHeader), new System.Windows.PropertyMetadata(null));

        // Header Content (right part content)
        public object HeaderContent
        {
            get { return (object)GetValue(HeaderContentProperty); }
            set { SetValue(HeaderContentProperty, value); }
        }
        public static readonly System.Windows.DependencyProperty HeaderContentProperty =
            System.Windows.DependencyProperty.Register("HeaderContent", typeof(object), typeof(UIHeader), new System.Windows.PropertyMetadata(null));

    }
}
