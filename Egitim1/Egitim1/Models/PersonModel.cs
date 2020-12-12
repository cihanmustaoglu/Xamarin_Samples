using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Egitim1.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string _name;
        //public string Name { get; set; }
        public string Name {
            get
            {
                return _name;
            }

            set {
                _name = value;
                onPropertyChanged("Name");
            } }

        public string Surname { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        void onPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
