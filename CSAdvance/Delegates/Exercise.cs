using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAdvance.Delegates
{
    class Exercise
    {
        public static void Start()
        {
            var photoProcessor = new PhotoProcessor();
            photoProcessor.Process("Image.jpg");
        }
    }
}
