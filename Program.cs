using System;

namespace pattern_adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var image1 = new Image();
            var imageView = new ImageView(image1);
            imageView.Apply(new VividFilter());
            // imageView.Apply(new Caramel());
            imageView.Apply(new CaramelFilter(new AvaFilter.Caramel())); // Composition
            imageView.Apply(new CaramelAdapter()); // Inheritance
                                                   // Choose composition over Inheritance

        }
    }
}
