using Session03OOP.Interface_Ex02;

namespace Session03OOP
{
    internal class Program
    {
        #region Video03 Interface EX02
        // static void Print10Numbers(SeriesByTwo seriesByTwo)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{seriesByTwo.Current} ");
        //        seriesByTwo.Next();

        //    }
        //    seriesByTwo.Reset();
        //}
        // static void Print10Numbers(SeriesByThree seriesByThree)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{seriesByThree.Current} ");
        //        seriesByThree.Next();

        //    }
        //    seriesByThree.Reset();
        //}
        // static void Print10Numbers(SeriesByFour seriesByFour)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{seriesByFour.Current} ");
        //        seriesByFour.Next();

        //    }
        //    seriesByFour.Reset();
        //}
        static void Print10Numbers(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current} ");
                series.Next();

            }
            series.Reset();
            Console.WriteLine();
        }
        #endregion
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
            #region Video03  Interface EX02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();

            //Print10Numbers(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10Numbers(seriesByThree);

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10Numbers(seriesByFour);

            //int[] Arr = { 7, 6, 5, 4, 3, 8, 1, 2 };
            //Array.Sort(Arr);
            //foreach (int item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Employee[] employees =new Employee[3]
            //{
            //    new Employee(){Id=1,Name="Ahmed",Age=30,Salary=12000},
            //    new Employee(){Id=2,Name="Omar",Age=29,Salary=11000},
            //    new Employee(){Id=3,Name="Ali",Age=28,Salary=10000},
            //};

            //Array.Sort(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);   
            //}
            #endregion
        }
    }
}
