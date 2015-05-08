using System.Windows;
using System.Windows.Controls;

namespace WpfFlatUI.Controls
{
    /// <summary>
    /// Interaction logic for ColorSwatch.xaml
    /// </summary>
    public partial class ColorSwatch : UserControl
    {
        public ColorSwatch()
        {
            InitializeComponent();
        }

        public string HexText
        {
            get { return (string)GetValue(HexTextProperty); }
            set { SetValue(HexTextProperty, value); }
        }

        public static readonly DependencyProperty HexTextProperty =
            DependencyProperty.Register("HexText", typeof(string),
            typeof(ColorSwatch), new PropertyMetadata("#FF0000"));

        public string ColorDescription
        {
            get { return (string)GetValue(ColorDescriptionProperty); }
            set { SetValue(ColorDescriptionProperty, value); }
        }

        public static readonly DependencyProperty ColorDescriptionProperty =
            DependencyProperty.Register("ColorDescription", typeof(string),
            typeof(ColorSwatch), new PropertyMetadata("Red"));
    }
}
