using C43_G03_OOP04.Classes;
using C43_G03_OOP04.Interfaces;

namespace C43_G03_OOP04
{
    #region first project
    //class Point3D : ICloneable, IComparable<Point3D>
    //{
    //    private int x { get; set; }
    //    private int y { get; set; }
    //    private int z { get; set; }

    //    public Point3D(int x, int y, int z)
    //    {
    //        this.x = x;
    //        this.y = y;
    //        this.z = z;
    //    }

    //    public Point3D(int x, int y) : this(x, y, 0) { }

    //    public Point3D(int x) : this(x, 0, 0) { }

    //    public Point3D() { }

    //    public override string ToString()
    //    {
    //        return $"point coordinates ({this.x}, {this.y}, {this.z})";
    //    }

    //    public static bool operator ==(Point3D p1, Point3D p2)
    //    {
    //        if (ReferenceEquals(p1, null ) && ReferenceEquals(p2, null))
    //            return true;
    //        if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
    //            return false;
    //        return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
    //    }

    //    public static bool operator !=(Point3D p1, Point3D p2)
    //    {
    //        return !(p1 == p2);
    //    }

    //    public object Clone()
    //    {
    //        return new Point3D(this.x, this.y, this.z);
    //    }

    //    public int CompareTo(Point3D p)
    //    {
    //        if (p == null) return 1;

    //        int xC = x.CompareTo(p.x);
    //        if(xC != 0) return xC;

    //        return y.CompareTo(p.y);
    //    } 
    #endregion


#region Second Project
        //public static class Math
        //{
        //    public static double Add(double num1, double num2)
        //    {
        //        return num1 + num2;
        //    }

        //    public static double Subtract(double num1, double num2)
        //    {
        //        return num1 - num2;
        //    }

        //    public static double Multiply(double num1, double num2)
        //    {
        //        return num1 * num2;
        //    }

        //    public static double Divide(double num1, double num2)
        //    {
        //        if (num2 == 0)
        //        {
        //            Console.WriteLine("can't divide by zero");
        //        }
        //        return num1 / num2;
        //    }
        //}
        #endregion

        #region Third Project

        #region Part01
        //public abstract class Discount
        //{
        //    public string Name { get; protected set; }

        //    protected Discount(string name)
        //    {
        //        Name = name;
        //    }

        //    public abstract decimal CalculateDiscount(decimal price, int quantity);
        //}
        #endregion

        #region Part02
        //public class PercentageDiscount : Discount
        //{
        //    private decimal _percentageOff;

        //    public PercentageDiscount(decimal percentageOff) : base("Percentage Discount")
        //    {
        //        if (percentageOff < 0 || percentageOff > 100)
        //            Console.WriteLine("Percentage must be between 0 and 100");

        //        _percentageOff = percentageOff;
        //    }

        //    public override decimal CalculateDiscount(decimal price, int quantity)
        //    {
        //        return price * quantity * (_percentageOff / 100);
        //    }
        //}

        //public class FlatDiscount : Discount
        //{
        //    private decimal _flatAmount;

        //    public FlatDiscount(decimal flatAmount) : base("Flat Discount")
        //    {
        //        if (flatAmount < 0)
        //            Console.WriteLine("Flat amount cannot be negative");

        //        _flatAmount = flatAmount;
        //    }

        //    public override decimal CalculateDiscount(decimal price, int quantity)
        //    {
        //        return _flatAmount * Math.Min(quantity, 1);
        //    }
        //}

        //public class BuyOneGetOneDiscount : Discount
        //{
        //    public BuyOneGetOneDiscount() : base("Buy One Get One Discount")
        //    {
        //    }

        //    public override decimal CalculateDiscount(decimal price, int quantity)
        //    {
        //        if (quantity <= 1)
        //            return 0;

        //        return (price / 2) * (quantity / 2);
        //    }
        //}

        //public class NoDiscount : Discount
        //{
        //    public NoDiscount() : base("No Discount")
        //    {
        //    }

        //    public override decimal CalculateDiscount(decimal price, int quantity)
        //    {
        //        return 0;
        //    }
        //}
        #endregion

        #region Part03
        //public abstract class User
        //{
        //    public string Name { get; protected set; }

        //    protected User(string name)
        //    {
        //        if (string.IsNullOrWhiteSpace(name))
        //            Console.WriteLine("Name cannot be empty");

        //        Name = name;
        //    }

        //    public abstract Discount GetDiscount();
        //}

        //public class RegularUser : User
        //{
        //    public RegularUser(string name) : base(name)
        //    {
        //    }

        //    public override Discount GetDiscount()
        //    {
        //        return new PercentageDiscount(5); 
        //    }
        //}

        //public class PremiumUser : User
        //{
        //    public PremiumUser(string name) : base(name)
        //    {
        //    }

        //    public override Discount GetDiscount()
        //    {
        //        return new FlatDiscount(100);
        //    }
        //}

        //public class GuestUser : User
        //{
        //    public GuestUser(string name) : base(name)
        //    {
        //    }

        //    public override Discount GetDiscount()
        //    {
        //        return new NoDiscount(); 
        //    }
        //}
        #endregion

        #endregion





}

        internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01:

            //Circle circle = new Circle(4);
            //Rectangle rect = new Rectangle(3, 4);

            //circle.DisplayShapeInfo();
            //rect.DisplayShapeInfo();

            #endregion

            #region Question 02:

            //IAuthenticationService authenticationService = new BasicAuthenticationService();

            //if(authenticationService.AuthenticateUser("admin", "1111"))
            //{
            //    if (authenticationService.AuthorizeUser("admin", "admin"))
            //        Console.WriteLine("correct role");
            //    else
            //        Console.WriteLine("wrong role");
            //}
            //else
            //    Console.WriteLine("wrong username and password combination");


            #endregion

            #region Question 03:

            //INotificationService email = new EmailNotificationService();
            //INotificationService sms = new SmsNotificationService();
            //INotificationService push = new PushNotificationService();

            //email.SendNotification("marwan@mail.com", "hi");
            //sms.SendNotification("011242", "hi");
            //push.SendNotification("ahmed", "hi");

            #endregion

        }
    }
}
