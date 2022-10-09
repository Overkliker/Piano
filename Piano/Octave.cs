using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Piano
{
    public class Octave
    {
        static int soundTime = 500; 
        public int oct = 0;

        public Dictionary<string, int> f_oct = new Dictionary<string, int> {
            ["q"] = 130, ["w"] = 138,
            ["e"] = 147, ["r"] = 155,
            ["t"] = 164, ["y"] = 174,
            ["u"] = 185, ["i"] = 196,
            ["o"] = 207, ["p"] = 220,
            ["f"] = 233, ["h"] = 247 };
        public Dictionary<string, int> s_oct = new Dictionary<string, int>();
        public Dictionary<string, int> fd_oct = new Dictionary<string, int>();
        public Dictionary<string, int> fo_oct = new Dictionary<string, int>();
        public Dictionary<string, int> fi_oct = new Dictionary<string, int>();
        public Dictionary<string, int> sx_oct = new Dictionary<string, int>() {
            ["q"] = 4186, ["w"] = 4434,
            ["e"] = 4698, ["r"] = 4978, ["t"] = 5274 };

        public void upOct()
        {
            foreach (var i in f_oct)
            {
                int arc = i.Value * 2;
                int arc2 = arc * 2;
                int arc3 = arc2 * 2;
                int arc4 = arc3 * 2;

                s_oct.Add(i.Key, arc);
                fd_oct.Add(i.Key, arc2);
                fo_oct.Add(i.Key, arc3);
                fi_oct.Add(i.Key, arc4);

            }
        }

        public void setOctave(int num)
        {
            oct = num;
            
        }

        public void sound(string key)
        {
            switch (oct)
            {
                case 0:
                    System.Console.Beep(f_oct[key], soundTime);
                    break;
                case 1:
                    SystemSound.Beep();
                    break;

                case 2:
                    Console.Beep(fd_oct[key], soundTime);
                    break;

                case 3:
                    Console.Beep(fo_oct[key], soundTime);
                    break;

                case 4:
                    Console.Beep(fi_oct[key], soundTime);
                    break;

                case 5:
                    Console.Beep(sx_oct[key], soundTime);
                    break;
            }
        }


    }
}
