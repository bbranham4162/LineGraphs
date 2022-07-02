using System;
using PolarGraphs.Graphs;
using Services;
using Constant;
using Raylib_cs;

namespace Polar{


    public static class Program
    {



        public static void Main(string[] args)
        {

            VideoService videoservice = new VideoService();
            Constants constant = new Constants();

            int Range = 800;
            int VerticalShift = 300;
            int HorizontalShift = 500;
            int ExponentialFunction = -1;
            
            videoservice.initializeWindow(Range, Range, "Graph");
            videoservice.DrawFunction(ExponentialFunction, Color.BLACK, Range, HorizontalShift,VerticalShift  );

            Console.ReadKey();

        //     Graphs graphs = new Graphs();

        //     Console.WriteLine("What do you want your upperbounds to be?");

        //     int x = Convert.ToInt32(Console.ReadLine());

        //     Console.WriteLine("What do you want your lower bounds to be? ");

        //     int y = Convert.ToInt32(Console.ReadLine());
            
        //     graphs.SetUpperBound(x);

        //     graphs.SetLowerBound(y);

        //     VideoService videoService = new VideoService(false);

           

        //     videoService.OpenWindow();

        //     while (videoService.IsWindowOpen())
        //     {
        //         videoService.ClearBuffer();
        //     }
        //     videoService.CloseWindow();
         

        //     bool check = true;

        //     while (check)
        //     {
               
        //     }



        }
    }
}
