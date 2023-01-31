using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCalculaterBorwel
{
    internal class Program
    {

       PaintCalculations _calculations;

        VolumeCalculations _volumeCalculations;
        static void Main(string[] args)
        {
            VolumeCalculations _volumeCalculations = new VolumeCalculations();
            _volumeCalculations.run();
        }
    }
}
