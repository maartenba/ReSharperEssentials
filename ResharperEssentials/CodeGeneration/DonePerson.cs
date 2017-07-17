using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ResharperEssentials.Annotations;

namespace ResharperEssentials.CodeGeneration
{
    public class DonePerson : INotifyPropertyChanged, IComparable<DonePerson>, IComparable
    {
        protected bool Equals(DonePerson other)
        {
            return string.Equals(_name, other._name) && Age == other.Age;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DonePerson) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_name != null ? _name.GetHashCode() : 0) * 397) ^ Age;
            }
        }

        public static bool operator ==(DonePerson left, DonePerson right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DonePerson left, DonePerson right)
        {
            return !Equals(left, right);
        }

        private int _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public int CompareTo(DonePerson other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var nameComparison = string.Compare(_name, other._name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            return Age.CompareTo(other.Age);
        }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            if (!(obj is DonePerson)) throw new ArgumentException($"Object must be of type {nameof(DonePerson)}");
            return CompareTo((DonePerson) obj);
        }

        public static bool operator <(DonePerson left, DonePerson right)
        {
            return Comparer<DonePerson>.Default.Compare(left, right) < 0;
        }

        public static bool operator >(DonePerson left, DonePerson right)
        {
            return Comparer<DonePerson>.Default.Compare(left, right) > 0;
        }

        public static bool operator <=(DonePerson left, DonePerson right)
        {
            return Comparer<DonePerson>.Default.Compare(left, right) <= 0;
        }

        public static bool operator >=(DonePerson left, DonePerson right)
        {
            return Comparer<DonePerson>.Default.Compare(left, right) >= 0;
        }

        public int Age { get; set; }

        public DonePerson(int id, string name, int age)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            _id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}