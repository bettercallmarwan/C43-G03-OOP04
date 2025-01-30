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
