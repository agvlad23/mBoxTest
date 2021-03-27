using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ShapeArea
{
    public class Area
    {
        /* Попытка реализовать вычисление площади фигуры без знания типа фигуры
         * Непонятно что конкретно имеется ввиду, нужно ли продумать добавление новых фигур, какие данные мы должны получать от пользователя
         * Или использовать интегралы для вычисления с допустимой точностью
         */
        public static double AnyShape(double R)
        {
            return new Circle(R).Area();
        }
        public static double AnyShape(double side1,double side2,double side3)
        {
            return new Triangle(side1,side2,side3).Area();
        }

        //Пусть задается массив декартовых координат, тогда воспользуемся формулой площади Гаусса и найдем площадь простого многоугольника
        /// <summary>
        /// Finding area of the shape by using Gauss's area formula 
        /// </summary>
        /// <param name="points">Points of the shape labeled sequentially in the clockwise or counterclockwise direction</param>
        /// <returns>Area of the shape</returns>
        public static double AnyShape(Point[] points)
        {
            double area = 0;
            Point p = points[0];
            Point pPrev = points[points.Length-1];
            Point pNext = points[1];
            area += p.X * (pNext.Y - pPrev.Y);

            for (int i = 1; i < points.Length-1; i++)
            {
                pPrev = p;
                p = pNext;
                pNext = points[i + 1];
                area += p.X * (pNext.Y - pPrev.Y);


            }

            p = points[points.Length - 1];
            pPrev = points[points.Length - 2];
            pNext = points[0];
            area += p.X * (pNext.Y - pPrev.Y);

            return Math.Abs(area)/2;
        }
    }
}
