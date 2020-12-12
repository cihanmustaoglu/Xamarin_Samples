using Egitim1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Egitim1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonPage : ContentView
    {
        private readonly List<PersonModel> model = new List<Models.PersonModel>();
        public PersonPage()
        {
            InitializeComponent();
            BindData();
        }
        private void BindData()
        {
            model.Add(new PersonModel
            {
                Id = 1,
                Name = "Cihan",
                Surname = "Müştaoğlu"
            }) ;
            model.Add(new PersonModel
            {
                Id = 1,
                Name = "Feyza",
                Surname = "Yıldırım"
            });
            lstPerson.ItemsSource = model;
        }
    }
}