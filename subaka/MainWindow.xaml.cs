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

namespace subaka {

    public partial class MainWindow : Window {

		Window1 mainWindow = null;

        public MainWindow() {
            InitializeComponent();
        }

		private void Login(object sender, RoutedEventArgs e)
		{
			if (mainWindow == null)
			{
				mainWindow = new Window1();
				mainWindow.Show();
				Close();
			}
		}
			protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			
		}
    }
}
