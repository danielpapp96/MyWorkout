using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWorkout.Bll.Dto;
using MyWorkout.Bll.Services;

namespace MyWorkout.Web.Pages.WorkoutPlans
{
    public class AddWorkoutModel : PageModel
    {
        private readonly WorkoutPlanService workoutPlanService;
        private readonly ExerciseService exerciseService;

        public AddWorkoutModel( WorkoutPlanService workoutPlanService, ExerciseService exerciseService )
        {
            this.workoutPlanService = workoutPlanService;
            this.exerciseService = exerciseService;
        }

        [BindProperty]
        public WorkoutPlanDto WorkoutPlan { get; set; }
        [BindProperty]
        public int[] ExerciseIds { get; set; }

        public IEnumerable<ExerciseDto> Exercises { get; set; }

        public void OnGet()
        {
            Exercises = exerciseService.GetAllExerciseAsync();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            await workoutPlanService.AddNewWorkoutAsync(WorkoutPlan);
            return new RedirectToPageResult("/WorkoutPlans/Index");
        }
    }
}
