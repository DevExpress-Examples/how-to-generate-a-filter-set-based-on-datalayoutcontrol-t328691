using DevExpress.Utils.Filtering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace dxSampleGrid {
    public class PersonFilteringViewModel {
        [Display(Name = "Age")]
        [FilterRange("MinAge", "MaxAge", EditorType = RangeUIEditorType.Range)]
        public int Age { get; set; }

        [Display(Name = "Children")]
        [FilterLookup("NumberOfChildren")]
        public int Children { get; set; }

        [Display(Name = "HasCar")]
        [FilterBooleanChoice()]
        public bool HasCar { get; set; }

        [Display(Name = "BirthDate")]
        [FilterDateTimeRange("MinBirthDate", "MaxBirthDate")]
        public DateTime BirthDate { get; set; }
    }
}