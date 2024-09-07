using AutoMapper;
using DietX.Entities.Entities;
using DietX.UI.Vms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.UI
{
    public class ModelProfiler : Profile
    {
        public ModelProfiler()
        {
            CreateMap<UserMealReport, UserMealReportVm>()
                .ForMember(x => x.FoodName, x => x.MapFrom(x => x.Food.Name))
                .ForMember(x => x.CategoryName, x => x.MapFrom(x => x.Food.Category.Name))
                .ForMember(x => x.MealName, x => x.MapFrom(x => x.Meal.Name));

        }
    }
}
