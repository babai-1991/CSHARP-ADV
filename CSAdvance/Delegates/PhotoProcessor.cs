namespace CSAdvance.Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path,PhotoFilterHandler photoFilterHandler)
        {
            var photo = Photo.Load(path);
            photoFilterHandler(photo);
            photo.Save();
        }
    }

    //create a delegate
}