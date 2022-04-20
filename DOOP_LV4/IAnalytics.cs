using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV4
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
