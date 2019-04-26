using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BooksSample.Models
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void FirePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T item, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(item, value)) return false;

            item = value;
            FirePropertyChanged(propertyName);
            return true;
        }
    }
}
