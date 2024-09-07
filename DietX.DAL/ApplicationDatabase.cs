using DietX.DAL.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL
{
    public class ApplicationDatabase
    {
        private static DietXDbContext context;

        public static DietXDbContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new DietXDbContext();
                }
                return context;
            }
        }
    }
}
