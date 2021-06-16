using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace WpfApp1
{
    public static class Navigator
    {
        public static object DataToPass { get; set; }

       private static NavigationService NavigationService { get; } = (Application.Current.MainWindow as MainWindow).Main.NavigationService;

       public static void Navigate(string path, object param = null)
       {
            NavigationService.Navigate(new Uri(path, UriKind.RelativeOrAbsolute), param);
            DataToPass = param;
       }

       public static void GoBack()
       {
            NavigationService.GoBack();
       }

       public static void GoForward()
       {
            NavigationService.GoForward();
       }
    }
}
