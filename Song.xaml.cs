using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Song.xaml
    /// </summary>
    public partial class Song : UserControl
    {


        public string SongName
        {
            get { return (string)GetValue(SongNameProperty); }
            set { lblSongName.Content = value; SetValue(SongNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SongName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SongNameProperty =
            DependencyProperty.Register("SongName", typeof(string), typeof(Song));


        public Song()
        {
            InitializeComponent();
            this.lblSongName.Content = "Something";
        }
    }
}
