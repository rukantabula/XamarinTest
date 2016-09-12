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

            MainListView.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name = "Mohamed",
                    Age = 26
                },
                    new Person
                {
                    Name = "benson",
                    Age = 34
                },
                        new Person
                {
                    Name = "kam",
                    Age = 23
                },
                    new Person
                {
                    Name = "Allan",
                    Age = 20
                },
                    new Person
                {
                    Name = "Mohamed",
                    Age = 26
                },
                    new Person
                {
                    Name = "benson",
                    Age = 34
                },
                        new Person
                {
                    Name = "kam",
                    Age = 23
                },
                    new Person
                {
                    Name = "Allan",
                    Age = 20
                }

            };
        }

    
    }
}
