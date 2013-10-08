using System.Windows.Controls;
using System.Xml.Linq;

namespace XMLTreeView
{
    public class TreeViewControl : Control
    {
        //public static readonly DependencyProperty IconSourceProperty =
        //  DependencyProperty.Register("IconSource",
        //  typeof(ImageSource),
        //  typeof(TreeViewControl),
        //  null);

        //public ImageSource IconSource
        //{
        //    get { return base.GetValue(IconSourceProperty) as ImageSource; }
        //    set { base.SetValue(IconSourceProperty, value); }
        //}

        public TreeViewControl()
        {
            DefaultStyleKey = typeof(TreeViewControl);
        }

        public static void Parse(string xml)
        {
        }
        public static void Load(XDocument xml)
        {

        }
    }
}
