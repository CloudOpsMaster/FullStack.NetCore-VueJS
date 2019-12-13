using System;


internal class Vehicle
{
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public double Speed { get; set; }
    public double Price { get; set; }
    public double YearOfLaunch { get; set; }


    public void Coordinate(double CoordinateX, double CoordinateY)
    {
        this.CoordinateX = CoordinateX;
        this.CoordinateY = CoordinateY;
    }

    public void SpeedMethod(double Speed)
    {
        this.Speed = Speed;
    }

}


  class Plane : Vehicle
    {
        private double highness;
        private double numberOfPassengers { get; set; }


    }

    class Ship : Vehicle
    {
        private string homePort;
    }

    class Car : Vehicle
    {

    }

