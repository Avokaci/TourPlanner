using System;
using System.Collections.Generic;
using System.Text;
using TourPlanner.BusinessLayer;

namespace TourPlanner.BL
{
    public class TourItemFactory
    {
        private static ITourItemFactory instance;

        public static ITourItemFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new TourItemFactoryImpl();
            }
            return instance;
        }
    }
}
