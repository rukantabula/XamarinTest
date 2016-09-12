using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinStart1
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<string>
            {

                "Mohamed","Allan","benson","kam"
            };
        }

    
    }
}
