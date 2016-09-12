using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinStart1
{
    public partial class Page1 : ContentPage
    {
        public Page1(string paramter)
        {
            InitializeComponent();
            MainLabel.Text = paramter;
        }
    }
}
