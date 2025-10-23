using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Criticografo_GAFF.Model
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string genero;
        private bool isTall;
        private bool isSmart;
        private bool isRare;
        private bool isUgly;
        private bool isExtravagant;
        private bool isBig;

        public string Name 
        { 
            get => name; 
            set 
            {  
                name = value; 
                OnPropertyChanged();
            } 
        }
        public string Genero 
        { 
            get => genero; 
            set 
            {  
                genero = value; 
                OnPropertyChanged();
            } 
        }
        public bool IsTall 
        { 
            get => isTall;
            set
            {
                 isTall = value;
                 OnPropertyChanged();
            } 
        }
        public bool IsSmart
        {
            get => isSmart; set 
            {  
                isSmart = value;
                OnPropertyChanged();
            } 
        }
        public bool IsRare 
        { 
            get => isRare;
            set 
            {  
                isRare = value; 
                OnPropertyChanged();
            }
        }
        public bool IsUgly 
        { 
            get => isUgly;
            set
            {
                isUgly = value;
                OnPropertyChanged();
            }
        }
        public bool IsExtravagant 
        { 
            get => isExtravagant; 
            set
            {
                isExtravagant = value;
                OnPropertyChanged();
            } 
        }
        public bool IsBig 
        { 
            get => isBig; 
            set
            {
                isBig = value;
                OnPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
