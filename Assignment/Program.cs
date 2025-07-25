using Assignment.Interfaces;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q1
            //b) To define a blueprint for a class
            #endregion

            #region Q2
            //b) protected
            #endregion
            #region Q3
            //b) No
            #endregion
            #region Q4
            //  b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region Q5
            //  d) implements
            #endregion
            #region Q6
            //  a) Yes
            #endregion
            #region Q7
            // a) Yes, for all members
            #endregion
            #region Q8
            // a) To hide the interface members from outside access
            #endregion
            #region Q9
            //b) No, interfaces cannot have constructors
            #endregion
            #region Q10
            //c) By separating interface names with commas
            #endregion
            #endregion
            #region Part02
            #region Q1
            //double X, Y, Radius;
            //do
            //{
            //    Console.Write("Enter width of rectangle: ");
            //}
            //while (!double.TryParse(Console.ReadLine(), out X));
            //do
            //{
            //    Console.Write("Enter height of rectangle: ");
            //}
            //while (!double.TryParse(Console.ReadLine(), out Y));
            //Console.WriteLine();
            //do
            //{
            //    Console.Write("Enter radius of circle: ");
            //}
            //while (!double.TryParse(Console.ReadLine(), out Radius));

            //IShape shape = new Circle(Radius);
            //Console.WriteLine("Area of circle is: ");
            //shape.DisplayShapeInfo();
            //Console.WriteLine();
            //shape = new Rectangle(X, Y);
            //Console.WriteLine("Area of rectangle is: ");
            //shape.DisplayShapeInfo();
            #endregion

            #region Q2
            //IAuthenticationService authenticationService;
            //User user=new User() { Username="Wissam",Password="123",Role="Admin"};
            //BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService(user);
            //authenticationService = basicAuthenticationService;
            //Console.WriteLine($"is wissam authorized?:{authenticationService.AuthenticateUser("wissam","123")}");
            //Console.WriteLine($"is Ahmed authorized?:{authenticationService.AuthenticateUser("ahmed","123")}");

            //Console.WriteLine();
            //Console.WriteLine($"Is wissam is admin?: {authenticationService.AuthorizeUser("Admin")}");
            //Console.WriteLine($"Is wissam is HR?: {authenticationService.AuthorizeUser("hr")}");
            #endregion

            #region Q3
            INotificationService notificationService;
            notificationService = new EmailNotificationService();
            notificationService.SendNotification("Wissam", "Hello :)");
            notificationService=new SmsNotificationService();
            Console.WriteLine();
            notificationService.SendNotification("Ali", "Please call me back");

            notificationService=new PushNotificationService();
            Console.WriteLine();
            notificationService.SendNotification("Omar", "See you soon");
            #endregion
            #endregion

        }
    }
}
