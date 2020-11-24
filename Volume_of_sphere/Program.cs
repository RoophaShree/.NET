using System;

namespace Volume_of_sphere
{
    class Sphere
    {
        public static float CalculateVolume(float radius)
        {
            float volume = 0.0F;

            volume = (float)(4.0 / 3 * Math.PI * radius * radius * radius);

            return volume;
        }
        public static void Main()
        {
            float radius = 0.0F;
            float volume = 0.0F;

            Console.Write("Enter the value of radius: ");
            radius = float.Parse(Console.ReadLine());

            volume = CalculateVolume(radius);
            Console.WriteLine("Volume of Sphere: " + volume);
        }
    }
}