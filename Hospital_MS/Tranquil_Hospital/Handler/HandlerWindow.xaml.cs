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
using System.Windows.Shapes;

namespace Hos_01.Handler
{
    /// <summary>
    /// Interaction logic for HandlerWindow.xaml
    /// </summary>
    public partial class HandlerWindow : Window
    {
        public HandlerWindow(HandlerWindowVM vM)
        {

            DataContext = vM;
            InitializeComponent();
        }
    }
}
