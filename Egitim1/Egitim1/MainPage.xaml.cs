using Egitim1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Egitim1
{
    public partial class MainPage : ContentPage
    {
        //private readonly IList<PersonModel> model = new ObservableCollection<Models.PersonModel>();

        public MainPage()
        {
            InitializeComponent();

        }

        
        //private void onDelete(object sender,EventArgs e)
        //{
          //  MenuItem item = (MenuItem)sender;
            //PersonModel selectedModel = (PersonModel)item.CommandParameter;
            //if (selectedModel != null)
              //  model.Remove(selectedModel);

        //}
        //private void onUpdate(object sender, EventArgs e)
        //{
          //  MenuItem item = (MenuItem)sender;
          // PersonModel selectedModel = (PersonModel)item.CommandParameter;
          //  if (selectedModel != null)
          //      selectedModel.Name = selectedModel.Surname.Substring(0, 1) + "." + selectedModel.Name;
        //}


    }
}
