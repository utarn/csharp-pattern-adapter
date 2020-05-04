using pattern_adapter.AvaFilter;

namespace pattern_adapter
{
    public class CaramelAdapter : Caramel, Filter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}