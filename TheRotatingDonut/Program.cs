using System;

namespace ConsoleApp
{
    class Program
    { //version 1 of the donut app 
        static void Main(string[] args)
        {
            // Set the console window size and title.
            Console.SetWindowSize(80, 25);
            Console.Title = "Rotating Donut";

            // Set the foreground and background colors.
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;

            // Create an array of characters to represent the donut.

            // Use the string "DONUT" for the donut.
            char[] donut = new char[] { 'o', 'o', 'd', 'o', 'n', 'u', 't', 'o', 'o' };

            // Store the x and y coordinates of the donut.
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;

            // Store the angle of rotation for the donut.
            double angle = 0;

            // Store the speed of rotation for the donut.
            double speed = 144;

            // Write the donut to the console in a loop.
            while (true)
            {
                // Clear the console.
                Console.Clear();

                // Calculate the new position of the donut based on the current angle of rotation.
                int newX = (int)(x + Math.Cos(angle) * 17);
                int newY = (int)(y + Math.Sin(angle) * 10);

                // Write the donut at the new position.
                Console.SetCursorPosition(newX, newY);
                Console.Write(donut);

                // Increment the angle of rotation.
                angle += speed;

                // Pause for a short time before continuing the loop.
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{ //version 2 
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Set the console window size and position
//            Console.SetWindowSize(100, 30);
//            Console.SetBufferSize(100, 30);
//            Console.SetWindowPosition(0, 0);

//            // Create a list of points for the donut
//            List<Tuple<double, double, double>> points = new List<Tuple<double, double, double>>();
//            int numPoints = 50;
//            double outerRadius = 10;
//            double innerRadius = 5;
//            for (int i = 0; i < numPoints; i++)
//            {
//                double angle = 2 * Math.PI * i / numPoints;
//                double x = outerRadius * Math.Cos(angle);
//                double y = outerRadius * Math.Sin(angle);
//                points.Add(new Tuple<double, double, double>(x, y, 0));
//            }
//            for (int i = 0; i < numPoints; i++)
//            {
//                double angle = 2 * Math.PI * i / numPoints;
//                double x = innerRadius * Math.Cos(angle);
//                double y = innerRadius * Math.Sin(angle);
//                points.Add(new Tuple<double, double, double>(x, y, 0));
//            }

//            // Set the initial angle of rotation
//            double angleX = 0;
//            double angleY = 0;
//            double angleZ = 0;

//            // Rotate the donut in a loop
//            while (true)
//            {
//                // Clear the console
//                Console.Clear();

//                // Create a list of rotated points
//                List<Tuple<double, double, double>> rotatedPoints = new List<Tuple<double, double, double>>();
//                foreach (var point in points)
//                {
//                    double x = point.Item1;
//                    double y = point.Item2;
//                    double z = point.Item3;

//                    // Rotate the point around the X axis
//                    double rotatedX = x;
//                    double rotatedY = y * Math.Cos(angleX) - z * Math.Sin(angleX);
//                    double rotatedZ = y * Math.Sin(angleX) + z * Math.Cos(angleX);

//                    // Rotate the point around the Y axis
//                    x = rotatedX * Math.Cos(angleY) + rotatedZ * Math.Sin(angleY);
//                    y = rotatedY;
//                    z = -rotatedX * Math.Sin(angleY) + rotatedZ * Math.Cos(angleY);

//                    // Rotate the point around the Z axis
//                    rotatedX = x * Math.Cos(angleZ) - y * Math.Sin(angleZ);
//                    rotatedY = x * Math.Sin(angleZ) + y * Math.Cos(angleZ);
//                    rotatedZ = z;

//                    // Add the rotated point to the list
//                    rotatedPoints.Add(new Tuple<double, double, double>(rotatedX, rotatedY, rotatedZ));










//                    // Project the 3D points onto a 2D plane
//                    List<Tuple<int, int>> projectedPoints = new List<Tuple<int, int>>();
//                    foreach (var pointss in rotatedPoints)
//                    {
//                        double a = pointss.Item1;
//                        double b = pointss.Item2;
//                        double c = pointss.Item3;

//                        // Perform the projection
//                        double focalLength = 50;
//                        int projectedX = (int)(focalLength * x / (z + focalLength));
//                        int projectedY = (int)(focalLength * y / (z + focalLength));

//                        // Add the projected point to the list
//                        projectedPoints.Add(new Tuple<int, int>(projectedX, projectedY));
//                    }

//                    // Draw the projected points in the console
//                    foreach (var pointss in projectedPoints)
//                    {
//                        Console.SetCursorPosition(pointss.Item1 + 50, pointss.Item2 + 15);
//                        Console.Write('*');
//                    }

//                    // Update the angle of rotation
//                    angleX += 0.01;
//                    angleY += 0.01;
//                    angleZ += 0.01;

//                    // Sleep for a short time to slow down the animation
//                    System.Threading.Thread.Sleep(20);


//                }
//            }
//        }

//    }
//}


