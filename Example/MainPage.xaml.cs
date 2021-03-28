using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Example
{
    public partial class MainPage : ContentPage
    {
        public class Contact
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
        public MainPage()
        {
            InitializeComponent();
        }

      

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            string userName = nameEntry.Text;
            greetinglabel.Text = $"Hello {userName}";
        }

    }
}
