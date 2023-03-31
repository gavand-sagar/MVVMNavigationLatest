using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public static class LoginService
    {


        public static int GetRoleBasedVisibility(DependencyObject obj)
        {
            return (int)obj.GetValue(RoleBasedVisibilityProperty);
        }

        public static void SetRoleBasedVisibility(DependencyObject obj, int value)
        {
           
            obj.SetValue(RoleBasedVisibilityProperty, value);
        }

        // Using a DependencyProperty as the backing store for RoleBasedVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RoleBasedVisibilityProperty =
            DependencyProperty.RegisterAttached("RoleBasedVisibility", typeof(int), typeof(LoginService),new PropertyMetadata(0), o =>
            {
                //Button b = (Button)o;
                return true;
            });


    }
}
