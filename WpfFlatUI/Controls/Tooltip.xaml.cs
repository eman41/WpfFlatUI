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

namespace WpfFlatUI.Controls
{
    /// <summary>
    /// Interaction logic for Tooltip.xaml
    /// </summary>
    public partial class Tooltip : UserControl
    {
        public Tooltip()
        {
            InitializeComponent();
        }

        public bool IsUnderText
        {
            get { return (bool)GetValue(IsUnderTextProperty); }
            set { SetValue(IsUnderTextProperty, value); }
        }

        public string TipText
        {
            get { return (string)GetValue(TipTextProperty); }
            set { SetValue(TipTextProperty, value); }
        }

        public static readonly DependencyProperty IsUnderTextProperty = DependencyProperty.Register(
            "IsUnderText", typeof(bool), typeof(Tooltip), new PropertyMetadata(true)
        );

        public static readonly DependencyProperty TipTextProperty = DependencyProperty.Register(
            "TipText", typeof(string), typeof(Tooltip), new PropertyMetadata(string.Empty)
        );
    }
}
