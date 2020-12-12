using Egitim1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Egitim1.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private bool _isRefreshing;
        public PersonViewModel(){
            BindData();
            deleteCommand=new Command(onDelete);
            updateCommand=new Command(onUpdate);
            refreshCommand = new Command(onRefresh);
        }
        ICommand deleteCommand, updateCommand,refreshCommand;

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                onPropertyChanged();
            }
        }
        private void BindData()
        {
            this.IsRefreshing = true;
            Person.Clear();
            Person.Add(new PersonModel
            {
                Id = 1,
                Name = "Cihan",
                Surname = "Müştaoğlu"
            });
            Person.Add(new PersonModel
            {
                Id = 1,
                Name = "Feyza",
                Surname = "Yıldırım"
            });
            this.IsRefreshing = false;

        }



        private ObservableCollection<PersonModel> _person;

        public event PropertyChangedEventHandler PropertyChanged;
        void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<PersonModel> Person
        {
            get {
                if (_person == null)
                    _person = new ObservableCollection<PersonModel>();    
                return _person; }
            set { _person = value; }
        }


        private void onDelete(object param)
        {
            PersonModel selectedModel = (PersonModel)param;
            if (selectedModel != null)
                Person.Remove(selectedModel);
        }

        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand;
            }
            set
            {
                if (deleteCommand == null)
                    return;
                deleteCommand = value;
            }
        }


        public ICommand UpdateCommand
        {
            get
            {
                return updateCommand;
            }
            set
            {
                if (updateCommand == null)
                    return;
                updateCommand = value;
            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return refreshCommand;
            }
            set
            {
                if (refreshCommand == null)
                    return;
                refreshCommand = value;
            }
        }
        private void onUpdate(object param)
        {
            PersonModel selectedModel = (PersonModel)param;
            if (selectedModel != null)
                selectedModel.Name = selectedModel.Surname.Substring(0, 1) + "." + selectedModel.Name;

        }

        private void onRefresh()
        {
            BindData();

        }
    } 
}
