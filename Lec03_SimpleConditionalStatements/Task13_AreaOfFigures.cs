using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Task 13
 Да се напише програма, която въвежда размерите на геометрична фигура и пресмята лицето й.
 Фигурите са четири вида: квадрат (square), правоъгълник (rectangle), кръг (circle) и триъгълник (triangle). 
 На първия ред на входа се чете вида на фигурата (square, rectangle, circle или triangle).
 Ако фигурата е квадрат, на следващия ред се чете едно число – дължина на страната му.
 Ако фигурата е правоъгълник, на следващите два реда четат две числа – дължините на страните му. 
 Ако фигурата е кръг, на следващия ред чете едно число – радиусът на кръга. 
 Ако фигурата е триъгълник, на следващите два реда четат две числа – дължината на страната му и дължината на височината към нея. Резултатът да се закръгли до 3 цифри след десетичната точка. 
 */
class AreaOfFigures
{
    static void Main()
    {
        string figure = Console.ReadLine();
        float area = 0;

        if (figure == "square")
        {
            float squareSide = float.Parse(Console.ReadLine());

            area = squareSide * squareSide;
        }
        else if (figure == "rectangle")
        {
            float rectangleWidth = float.Parse(Console.ReadLine());
            float squareHeght = float.Parse(Console.ReadLine());

            area = rectangleWidth * squareHeght;
        }
        else if (figure == "circle")
        {
            float circleRadius = float.Parse(Console.ReadLine());

            area = (float)Math.PI * circleRadius * circleRadius;
        }
        else
        {
            float triangleSideLength = float.Parse(Console.ReadLine());
            float triangleSideHeght = float.Parse(Console.ReadLine());

            area = (triangleSideLength * triangleSideHeght) / 2;
        }

        Console.WriteLine("{0:0.000}",area);
    }
}
