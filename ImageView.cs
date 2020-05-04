namespace pattern_adapter
{
    public class ImageView
    {
        private Image _image;

        public ImageView(Image image)
        {
            _image = image;
        }

        public void Apply(Filter filter)
        {
            filter.Apply(_image);
        }
    }
}