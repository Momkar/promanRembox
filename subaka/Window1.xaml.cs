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
using System.Data;

namespace subaka
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window {

	
		public Window1(){
			InitializeComponent();
		
		}

		
		protected override void OnClosed(EventArgs e)  {
			base.OnClosed(e);

			Application.Current.Shutdown();
		}

        private void projectsNew_Click(object sender, RoutedEventArgs e)
        {
            NewProject newproject = new NewProject();
            if (newproject.ShowDialog() == true);
            {
                
            }
        }
    }
}
