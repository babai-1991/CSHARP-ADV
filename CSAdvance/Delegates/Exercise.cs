using System;

namespace CSAdvance.Delegates
{
    class Exercise
    {
        public static void Start()
        {
            var photoProcessor = new PhotoProcessor();
            //Lets imagine this is our UI
            var photoFilter = new PhotoFilters();
            var photoFilterhandler = new PhotoFilterHandler(photoFilter.ApplyContrast);
            //chain
            photoFilterhandler+=photoFilter.ApplyBrightness;
            //use my own filters..
            photoFilterhandler+=Blur;

            photoProcessor.Process("Image.jpg",photoFilterhandler);
        }

        //user created this filter
        public static void Blur(Photo photo)
        {
            Console.WriteLine("Applying Blur effects....");
        }
    }
}
