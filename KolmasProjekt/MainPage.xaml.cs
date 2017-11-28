using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KolmasProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String username = "Kasutaja";
            String password = "Password123";

            if (textbox1.Text == username && textbox2.Text == password) 
            {
                textblock1.Text = "Sisselogimine õnnestus";
            }
            else
            {
                textblock1.Text = "Sisselogimine ebaõnnestus";
            }

            int LoginAttemps = 3;

            for (int i = 0; i < LoginAttemps; i++)
            {
                if (username != "Kasutaja" || password != "Password123")
                    LoginAttemps++;
                else
                    break;
                
            }

            if (LoginAttemps > 3)
            {
                textblock1.Text = "Too many failed attempts";
            }
            else
            {
                textblock1.Text = "Login successful";
            }
        }
    }
}
