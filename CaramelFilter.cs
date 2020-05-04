using pattern_adapter.AvaFilter;

namespace pattern_adapter
{
    public class CaramelFilter : Filter
    {
        private Caramel _caramel;

        public CaramelFilter(Caramel caramel)
        {
            _caramel = caramel;
        }

        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }
}