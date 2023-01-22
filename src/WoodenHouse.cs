using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.TemplateMethod
{
    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildPillars()
        {
            throw new NotImplementedException();
        }

        protected override void BuildRoof()
        {
            throw new NotImplementedException();
        }

        protected override void BuildWalls()
        {
            throw new NotImplementedException();
        }

        protected override void InstallDoors()
        {
            throw new NotImplementedException();
        }

        protected override void InstallWindows()
        {
            throw new NotImplementedException();
        }
    }
}
