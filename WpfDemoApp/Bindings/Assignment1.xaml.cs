using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfDemoApp.Bindings
{
  /// <summary>
  /// Interaction logic for Assignment1.xaml
  /// </summary>
  public partial class Assignment1 : Window
  {
    ObservableCollection<UserInfo> _userList;
    public Assignment1()
    {
      InitializeComponent();
      Loaded += Assignment1_Loaded;
    }
    private void Assignment1_Loaded(object sender, RoutedEventArgs e)
    {
      _userList = new ObservableCollection<UserInfo>();
      _userList.Add(new UserInfo { Username = "Tintin", Age = 10, Favcolor = "Red" });
      _userList.Add(new UserInfo { Username = "Haddock", Age = 21, Favcolor = "Green" });
      _userList.Add(new UserInfo { Username = "Snowy", Age = 7, Favcolor = "Gold" });

      this.DataContext = _userList;
    }
    private void btnAddUser_Click(object sender, RoutedEventArgs e)
    {
      _userList.Add(new UserInfo { Username = txtUserName.Text, Age = Convert.ToInt32(txtAge.Text), Favcolor = txtFavColor.Text });
    }
  }
}
