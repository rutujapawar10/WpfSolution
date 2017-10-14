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

namespace WpfDemoApp.Events
{
  /// <summary>
  /// Interaction logic for TunnlingEventWindow.xaml
  /// </summary>
  public partial class TunnlingEventWindow : Window
  {
    public TunnlingEventWindow()
    {
      InitializeComponent();

    }

    private void Button1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
      MessageBox.Show("Coming from button1");
    }

    private void InnerST_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
      MessageBox.Show("Coming from InnerST");
    }

    private void RootST_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
      MessageBox.Show("Coming from RootST");
    }
  }
}
