using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DDD.WinForm.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
            field = value;
            var h = this.PropertyChanged;
            if (h != null)
            {
                h(this, new PropertyChangedEventArgs(propertName));
            }
            return true;
        }
    }
}