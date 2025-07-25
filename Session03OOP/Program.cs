namespace Session03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video01 Revision
            //Class VS Struct
            //Inheritance
            //X-->Y
            //Relationship betwwn classes
            //Polymorphism(Overloading-overriding)
            //Binding 
            //1.Static binding ->New
            //2.Dynamic binding ->override
            #endregion

            #region Video02 Interface EX01
            //Interface is a REFERENCE TYPE
            // Is a code contract between the developer who write it and the developer
            //   who use it   [implementation]

            //IMyType myType=new IMyType();
            //NOTE:U can't create an object from interface

            //MyType myType=new MyType();
            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.Fun01();

            //IMyType myType;
            ////Reference->Can refer to any object of class implement the interface 'IMyType'
            //myType = new MyType();
            //myType.Salary = 1200;
            //Console.WriteLine(myType);
            //myType.Fun01();
            //myType.Print();
            #endregion
        }
    }
}
