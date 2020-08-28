using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class InstructorCohortViewModel
    {
        public Instructor instructor { get; set; }

        //A dropdown list for all of the cohorts
        public List<SelectListItem> cohorts { get; set; } = new List<SelectListItem>();
    }
}
