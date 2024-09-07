using DietX.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.UI.Vms
{
    public class FoodVm
    {
        public string Name { get; set; }
        public double Calorie { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
        public double Measure { get; set; }
        public PortionType PortionType { get; set; }
        public string Picture { get; set; }
        public int CategoryId { get; set; }
    }
}
