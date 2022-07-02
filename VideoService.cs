using System.Collections.Generic;
using System.Reflection.Metadata;
using Raylib_cs;
using Constant;


namespace Services
{

    class VideoService
    {

        
        public VideoService()
        {

        }

        // Initializes the Window 

        public void initializeWindow(int x, int y, string title)
        {
            Raylib.InitWindow(x, y, title );
            Raylib.BeginDrawing();

        }


        public void DrawFunction(int x_variable,  Color color, int Range, int HorizontalShift, int IntVerticalShift )
        {
            int[] values = Enumerable.Range(0, Range).ToArray();
            int y;

        foreach(int value in values)
        {   
            y = value^x_variable;
            Raylib.DrawPixel(value +HorizontalShift , -y + IntVerticalShift, color);
            Raylib.DrawLine(10, 0, 10, Range, Color.BLACK);
            Raylib.DrawLine(10, Range/2, Range, Range/2, Color.BLACK);
            
        }

          Raylib.EndDrawing() ; 
        }
    }
}