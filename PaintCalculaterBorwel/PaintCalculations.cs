using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCalculaterBorwel
{
    public class PaintCalculations
    {
        private const double paintPer1x1 = 0.2;

        int wallIndex = 1;
        string addWall;

        int absenceIndex = 1;
        string addAbsence;

        int cielingIndex = 1;
        string addCieling;

        List<int> addMeasurments = new List<int>();
        List<int> negateMeasurments = new List<int>();
        List<int> cielingMeasurments = new List<int>();

        public void run()
        {
            
            Main();
        }
        public void Main() 
        {
            Console.WriteLine("New Wall Y/N");
            addWall = Console.ReadLine().ToUpper();
            if (addWall == "Y") 
            {
                WallData();
            }

            Console.WriteLine("New cieling Y/N");
            addCieling = Console.ReadLine().ToUpper();
            if (addCieling == "Y")
            {
                CielingData();
            }

            Console.WriteLine("Absance of space in wall Y/N");
            addAbsence = Console.ReadLine().ToUpper();
            if (addAbsence == "Y")
            {
                AbsenseData();
            }

            CalculatedEnding();
        }

        public void WallData()
        {
            Console.WriteLine("Wall" + wallIndex);
            wallIndex++;

            Console.WriteLine("What is the room length? In meters");
            int roomLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the depth of the room? In meters");
            int roomDepth = Convert.ToInt32(Console.ReadLine());

            int wallCoverage = WallCoverageCalculation(roomLength, roomDepth);
            Console.WriteLine("wall = " + wallCoverage + "m squared");

            addMeasurments.Add(wallCoverage);

            Main();
        }

        public void CielingData()
        {
            Console.WriteLine("Cieling" + cielingIndex);
            cielingIndex++;

            Console.WriteLine("What is the room length? In meters");
            int roomLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the room width? In meters");
            int roomWidth = Convert.ToInt32(Console.ReadLine());

            int totalCielingCoverage = CielingCoverageCalcualtion(roomWidth, roomLength);
            Console.WriteLine("cieling = " + totalCielingCoverage + "m squared");

            cielingMeasurments.Add(totalCielingCoverage);

            Main();
        }

        public void AbsenseData()
        {
            Console.WriteLine("Absence" + absenceIndex);
            absenceIndex++;

            Console.WriteLine("Absnece Hieght?");
            int hieght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Absnece Width?");
            int width = Convert.ToInt32(Console.ReadLine());
            int windowsArea = hieght * width;
            Console.WriteLine("absence" + windowsArea);

            negateMeasurments.Add(windowsArea);  

            Main();
        }

        public int WallCoverageCalculation(int length, int depth)
        {
            
            int wallArea = length * depth;

            return wallArea;
        }

        public int CielingCoverageCalcualtion(int width, int length)
        {
            int cielingArea = width * length;

            return cielingArea;
        }

        public void CalculatedEnding()
        {
            int totalPaint  = 0;
            int cielingPaint = 0;
            for (var i = 0; i < addMeasurments.Count; i++)
            {
                
                totalPaint = totalPaint + addMeasurments[i];
            }

            for (var i = 0; i < negateMeasurments.Count; i++)
            {
                
                totalPaint = totalPaint - negateMeasurments[i];
            }

            for (var i = 0; i < cielingMeasurments.Count; i++)
            {
                
                cielingPaint = cielingPaint + cielingMeasurments[i];
            }

            Console.WriteLine( "Total Paint needed for room is " + totalPaint * paintPer1x1 + "l");

            Console.WriteLine("Paint for the cieling is " + cielingPaint * paintPer1x1 + "l");

            Console.WriteLine("Best to add some more paint if needed");
        }

    }
}
