using System;
using System.Linq;

namespace dxSampleGrid {
    public class Person {
        public Person(int i) {
            FirstName = "FirstName" + i;
            Age = i * 10;
            HasCar = i % 2 == 0;
            Children = i % 4;
            BirthDate = new DateTime(2010, 1, 1).AddDays(i);
        }

        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public int Children { get; set; }
        public string FirstName { get; set; }
        public bool HasCar { get; set; }
    }
}