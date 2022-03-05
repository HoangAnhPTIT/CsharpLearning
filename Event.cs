using System;

namespace ConsoleApp
{
    internal class Event
    {
        //private static void Main(string[] args)
        //{
        //    HocSinh hs = new HocSinh();
        //    hs.NameChanged += Hs_NameChanged;

        //    hs.Name = "A";
        //    hs.Name = "B";
        //}

        private static void Hs_NameChanged(object sender, NameChangedEventArgs e)
        {
            Console.WriteLine("Ten thay doi: " + e.Name);
        }
    }

    internal class HocSinh
    {
        private string _Name;

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnNameChanged(value);
            }
        }

        private event EventHandler<NameChangedEventArgs> _NameChanged;

        public event EventHandler<NameChangedEventArgs> NameChanged
        {
            add
            {
                _NameChanged += value;
            }

            remove
            {
                _NameChanged -= value;
            }
        }

        public void OnNameChanged(string name)
        {
            if (_NameChanged != null)
            {
                _NameChanged(this, new NameChangedEventArgs(name));
            }
        }
    }

    public class NameChangedEventArgs : EventArgs
    {
        public string Name { get; set; }

        public NameChangedEventArgs(string name)
        {
            Name = name;
        }
    }
}