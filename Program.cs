using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Suddenly the king cried to Snowmane and the horse sprang away. Behind him his banner blew in the wind, white horse upon a field of green, but he outpaced it. After him thundered the knights of his house, but he was ever before them.E´ omer rode there, the white horsetail on his helm floating in his speed, and the front of the first e´ored roared like a breaker foaming to the shore, but The´oden could not be overtaken. Fey he seemed, or the battle-fury of his fathers ran like new fire in his veins, and he was borne up on Snowmane like a god of old, even as Orome¨ the Great in the battle of the Valar when the world was young. His golden shield was uncovered, and lo! it shone like an image of the Sun, and the grass flamed into green about the white feet of his steed. For morning came, morning and a wind from the sea; and darkness was removed, and the hosts of Mordor wailed, and terror took them, and they fled, and died, and the hoofs of wrath rode over them. And then all the host of Rohan burst into song, and they sang as they slew, for the joy of battle was on them, and the sound of their singing that was fair and terrible came even to the City.";
            Console.WriteLine(phrase);
            Console.Write("Enter character : ");
            char input = Console.ReadKey().KeyChar;
            int count = CountChar(phrase, input);
            Console.WriteLine(input + " appeared " + count + " times.");
        }

        static int CountChar(string phrase, char letter)
        {
            int count = 0;
            foreach (char c in phrase)
            {
                if (letter == c) count++;
            }
            return count;
        }
    }
}
