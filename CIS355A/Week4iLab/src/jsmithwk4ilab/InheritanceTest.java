/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package jsmithwk4ilab;

/**
 *
 * @author Jon Smith
 */
public class InheritanceTest {



    public class Point
    {
        //Variables
        private double dblx;
        private double dbly;

        public Point()
        {

        }
        //Constructors
        public Point(double startX, double startY)
        {
            dblx = startX;
            dbly = startY;
        }

        //set Methods
        public void setX(double newX)
        {
            dblx = newX;
        }
        public void setY(double newY)
        {
            dbly = newY;
        }

        //To String methods
    }

    public class Square extends Point
    {
        //Variable
        private double dblSideLength;

        public Square()
        {

        }

        //Constructor Method
        public Square(double startSideLength, double startX, double startY)
        {
            super(startX, startY);
            dblSideLength = startSideLength;
        }

        //Set Method
        public void setSideLength(double newSideLength)
        {
            dblSideLength = newSideLength;
        }

        //Calcualtes the area
        public double Area(double dblSideLength)
        {
            double dblArea = dblSideLength * dblSideLength;

            return dblArea;
        }
    }

    public class Cube extends Square
    {
        private double dblDepth;

        public Cube()
        {

        }

        public Cube(double startDepth, double startSideLength, double startX, double startY)
        {
            super(startSideLength, startX, startY);
            dblDepth = startDepth;
        }
        public void setDepth(double newDepth)
        {
            dblDepth = newDepth;
        }
        public double Volume(double dblArea, double dblDepth)
        {
            double dblVolume = dblArea * dblDepth;
            return dblVolume;
        }
    }

}
