using System;

namespace Lesson7
{
    class LessonL7
    {
        public static void Main(string[] args)
        {
            Angle a = new Angle(3, 36, 53);
            Angle b = new Angle(4, 27, 45);
            var c = AngleCalculator.AngleCalculation(a, b);
            
            
            Console.WriteLine($"Angle A: {a.degrees}^ {a.minutes}’ {a.seconds}''");
            Console.WriteLine($"Angle B: {b.degrees}^ {b.minutes}’ {b.seconds}''");
            Console.WriteLine($"Angle C: {c.degrees}^ {c.minutes}’ {c.seconds}''");
        }
    }

    public class Angle //ICanSum//ICanSumAngles
    {

        public int degrees { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }

        public const int maxDegree = 360; //Can be more
        public const int maxMinutes = 60;
        public const int maxSeconds = 60;


        public Angle(int degrees, int minutes, int seconds)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.seconds = seconds;


            while (this.seconds >= maxSeconds)
            {
                this.seconds = this.seconds - 60;
                this.minutes = this.minutes + 1;
            }

            while (this.minutes >= maxMinutes)
            {
                this.minutes = this.minutes - 60;
                this.degrees = this.degrees + 1;
            }


        }


        //public Angle ICanSumAngles.AngleCalculation(Angle a, Angle b)
        //{
        //    var x = a.degrees + b.degrees;
        //    var y = a.minutes + b.minutes;
        //    var z = a.seconds + b.seconds;

        //    return new Angle(x, y, z);
        //}




    }

    public static class AngleCalculator
    {
        public static Angle AngleCalculation(Angle a, Angle b)
        {
            var x = a.degrees + b.degrees;
            var y = a.minutes + b.minutes;
            var z = a.seconds + b.seconds;
            Angle c = new Angle(x, y, z);

            return c;
        }
    }

    //public interface ICanSum
    //{
    //    public int SumDegrees();
    //    public int SumMinutes();
    //    public int SumSeconds();

    //}

    //public interface ICanSumAngles
    //{
    //    public Angle AngleCalculation(Angle a, Angle b);
    //}




}