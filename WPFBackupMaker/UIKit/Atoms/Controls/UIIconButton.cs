
namespace WPFBackupMaker.UIKit
{
    class UIIconButton : System.Windows.Controls.Button
    {
        // Icon (Geometry) for the button
        public System.Windows.Media.Geometry Icon
        {
            get { return (System.Windows.Media.Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly System.Windows.DependencyProperty IconProperty =
            System.Windows.DependencyProperty.Register("Icon", typeof(System.Windows.Media.Geometry), typeof(UIIconButton), new System.Windows.PropertyMetadata(null));
    }
}
