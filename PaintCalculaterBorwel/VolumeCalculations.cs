using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PaintCalculaterBorwel
{
    public class VolumeCalculations
    {
        PaintCalculations _calculations;
        public void run()
        {
            Main();
        }

        public void Main() 
        {
            VolumeCalc();
        }

        public void VolumeCalc()
        {
            Console.WriteLine("What is the room length? In meters");
            int roomLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the room width? In meters");
            int roomWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the depth of the room? In meters");
            int roomDepth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total romm volume = " + RoomVolume(roomWidth, roomLength, roomDepth) + "m cubed");
            Console.WriteLine("Total floor area = " + FloorCalc(roomWidth, roomLength) + "m sqaured");
            Transfer();
        }

        public int RoomVolume(int width, int length, int depth)
        {
            int coverage;

            coverage = (width * length) * depth;
            return coverage;
        }

        public int FloorCalc(int W, int L)
        {
            int total = (W * L);

            return total;
        }

        public void Transfer()
        {
            Console.WriteLine("Continue Y/N");
            string tranfer = Console.ReadLine().ToUpper();
            if (tranfer == "Y")
            {
                _calculations = new PaintCalculations();
                _calculations.run();
            }
            else if (tranfer != "N")
            {
                Console.WriteLine("Please punt either Y for yes or N for no");
                Transfer();
            }

        }
    }
}
