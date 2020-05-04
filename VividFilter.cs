namespace pattern_adapter
{
    public class VividFilter : Filter
    {
        public void Apply(Image image)
        {
            System.Console.WriteLine("Applying vivid filter");
        }
    }
}