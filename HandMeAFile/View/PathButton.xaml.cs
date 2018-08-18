using System.Windows;
using System.Windows.Media;

namespace org.ek.HandMeAFile.View
{
    /// <summary>
    /// Interaktionslogik für PathButton.xaml
    /// </summary>
    public partial class PathButton
    {
        public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register(nameof(PathData), typeof(Geometry), typeof(PathButton), new PropertyMetadata(default(Geometry)));
        public Geometry PathData
        {
            get => (Geometry)GetValue(PathDataProperty);
            set => SetValue(PathDataProperty, value);
        }

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(nameof(Color), typeof(Brush), typeof(PathButton), new PropertyMetadata(default(Brush)));
        public Brush Color
        {
            get => (Brush) GetValue(PathDataProperty);
            set => SetValue(PathDataProperty, value);
        }

        public static readonly DependencyProperty MouseOverColorProperty = DependencyProperty.Register(nameof(MouseOverColor), typeof(Brush), typeof(PathButton), new PropertyMetadata(default(Brush)));
        public Brush MouseOverColor
        {
            get => (Brush) GetValue(PathDataProperty);
            set => SetValue(PathDataProperty, value);
        }

        public PathButton()
        {
            InitializeComponent();
        }
    }
}
