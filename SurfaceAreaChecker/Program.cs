using System;

namespace SurfaceAreaChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer;
            Console.WriteLine("I will help you check the surface area of any of the following shapes: ");
            Console.WriteLine("Click '1' for Cuboid");
            Console.WriteLine("Click '2' for Cube");
            Console.WriteLine("Click '3' for Right Prism (Not fully implemented, needs LSA and base area)");
            Console.WriteLine("Click '4' for Right Circular Cylinder");
            Console.WriteLine("Click '5' for Right Circular Cone");
            Console.WriteLine("Click '6' for Solid Sphere");
            Console.WriteLine("Click '7' for Hemisphere");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Please enter the length, width, and height of the cuboid, each followed by pressing Enter:");
                    double lengthCuboid = Convert.ToDouble(Console.ReadLine());
                    double widthCuboid = Convert.ToDouble(Console.ReadLine());
                    double heightCuboid = Convert.ToDouble(Console.ReadLine());
                    answer = CuboidMath(lengthCuboid, widthCuboid, heightCuboid);
                    Console.WriteLine("The Surface Area of your Cuboid is: " + answer);
                    break;
                case 2:
                    Console.WriteLine("Please enter the edge length of the cube:");
                    double edgeLength = Convert.ToDouble(Console.ReadLine());
                    answer = CubeMath(edgeLength);
                    Console.WriteLine("The Surface Area of your Cube is: " + answer);
                    break;
                case 4:
                    Console.WriteLine("Enter the radius and height of the cylinder, separated by Enter:");
                    double radiusCylinder = Convert.ToDouble(Console.ReadLine());
                    double heightCylinder = Convert.ToDouble(Console.ReadLine());
                    answer = RightCircularCylinderMath(radiusCylinder, heightCylinder);
                    Console.WriteLine("The Surface Area of your Right Circular Cylinder is: " + answer);
                    break;
                case 5:
                    Console.WriteLine("Enter the radius and slant height of the cone, separated by Enter:");
                    double radiusCone = Convert.ToDouble(Console.ReadLine());
                    double slantHeight = Convert.ToDouble(Console.ReadLine());
                    answer = RightCircularConeMath(radiusCone, slantHeight);
                    Console.WriteLine("The Surface Area of your Right Circular Cone is: " + answer);
                    break;
                case 6:
                    Console.WriteLine("Enter the radius of the sphere:");
                    double radiusSphere = Convert.ToDouble(Console.ReadLine());
                    answer = SolidSphereMath(radiusSphere);
                    Console.WriteLine("The Surface Area of your Solid Sphere is: " + answer);
                    break;
                case 7:
                    Console.WriteLine("Enter the radius of the hemisphere:");
                    double radiusHemisphere = Convert.ToDouble(Console.ReadLine());
                    answer = HemisphereMath(radiusHemisphere);
                    Console.WriteLine("The Surface Area of your Hemisphere is: " + answer);
                    break;
                default:
                    Console.WriteLine("Please choose one of the numbers, we will be adding more soon!");
                    break;
            }
        }

        static double CuboidMath(double l, double w, double h)
        {
            return 2 * (l * w + w * h + l * h);
        }

        static double CubeMath(double b)
        {
            return 6 * Math.Pow(b, 2);
        }

        static double RightCircularCylinderMath(double r, double h)
        {
            return 2 * Math.PI * r * (r + h);
        }

        static double RightCircularConeMath(double r, double l)
        {
            return Math.PI * r * (l + r);
        }

        static double SolidSphereMath(double r)
        {
            return 4 * Math.PI * Math.Pow(r, 2);
        }

        static double HemisphereMath(double r)
        {
            return 3 * Math.PI * Math.Pow(r, 2);
        }
    }
}
