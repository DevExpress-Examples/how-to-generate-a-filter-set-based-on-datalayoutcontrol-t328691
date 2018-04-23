using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace dxSampleGrid {
    public class MainViewModel {
        public MainViewModel() {
            CreateList();
            CalculateFilterProperties();
        }

        private void CalculateFilterProperties() {
            NumberOfChildren = new int[] { 0, 1, 2, 3 };

            MinAge = ListPerson.Min(x => x.Age);
            MaxAge = ListPerson.Max(x => x.Age);

            MinBirthDate = ListPerson.Min(x => x.BirthDate);
            MaxBirthDate = ListPerson.Max(x => x.BirthDate);
        }

        void CreateList() {
            ListPerson = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++)
                ListPerson.Add(new Person(i));
        }

        public ObservableCollection<Person> ListPerson { get; set; }
        public int MaxAge { get; set; }
        public int MinAge { get; set; }
        public DateTime MaxBirthDate { get; set; }
        public DateTime MinBirthDate { get; set; }
        public int[] NumberOfChildren { get; set; }
    }
}