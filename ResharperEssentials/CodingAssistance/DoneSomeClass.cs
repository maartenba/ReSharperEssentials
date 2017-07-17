using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ResharperEssentials.Annotations;

namespace ResharperEssentials.CodingAssistance
{
    public class DoneSomeClass : INotifyPropertyChanged
    {
        List<string> names = new List<string>();
        private IEnumerable<string> foo = null;

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}