using Figur;
using System;

namespace TestCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основное задание.");
            Console.WriteLine("Нахождение площади круга через радиус.");
            Console.Write(" Введите радиус круга: ");
            double squareCircle = int.Parse(Console.ReadLine());
            double radiгsCircle = Square.Circle(squareCircle);
            Console.WriteLine(" Площадь круга: " + radiгsCircle);
            Console.WriteLine(" Основное заданите.");

            Console.WriteLine("Нахождение площади треугольника через три стороны.");
            Console.Write(" Введите первую сторону: ");
            double firstSide = int.Parse(Console.ReadLine());
            Console.Write(" Введите вторую сторону: ");
            double secondSide = int.Parse(Console.ReadLine());
            Console.Write(" Введите третью сторону: ");
            double thirdSide = int.Parse(Console.ReadLine());
            double squareTriangle = Square.Triangle(firstSide, secondSide, thirdSide);
            Console.WriteLine(" Площадь треугольника: " + squareTriangle);

            Console.WriteLine("Дополнительные задания.");
            Console.WriteLine(" Проверка на то, является ли треугольник прямоугольным.");
            Console.Write(" Введите первую сторону: ");
            firstSide = Square.Circle(int.Parse(Console.ReadLine()));
            Console.Write(" Введите вторую сторону: ");
            secondSide = Square.Circle(int.Parse(Console.ReadLine()));
            Console.Write(" Введите третью сторону: ");
            thirdSide = Square.Circle(int.Parse(Console.ReadLine()));
            string isEquilateral = TriangleOperation.isEquilateral(firstSide, secondSide, thirdSide) ? "равносторонний" : "неравносторонний";
            Console.WriteLine(" Этот треугольник " + isEquilateral);

            Console.WriteLine("Легкость добавления других фигур и сразу вычисление площади фигуры без знания типа фигуры в compile-time ");
            Console.Write(" Введите длинну стороны: ");
            double sideLength =int.Parse(Console.ReadLine());
            FigurBase square = new FlatSquare(sideLength);
            Console.WriteLine(" Площадь Квадрата: " + square.GetSquare());
            Console.WriteLine("Юнит тесты будут позже :(. В данный момент не успеваю сделать.");
            Console.ReadKey();
        }
    }
}
