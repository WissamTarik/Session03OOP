using Session03OOP.Interface_Ex02;
using Session03OOP.Session03OOP.Interface_Ex02;

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

            #region Video04 Interface EX03
            //Car car = new Car();
            //car.Speed = 120;
            //Console.WriteLine(car.Speed);
            //car.Forward();
            //Airplane airplane=new Airplane();

            //IFlyable flyable=airplane;
            //flyable.Forward();
            //IMovable movable = airplane;
            //movable.Forward();
            #endregion
            #region Video05 Shallow Copy Vs Deep Copy
            //Shallow Copy Vs Deep Copy


            //int[] Arr01= { 1, 2, 3 };
            //int[] Arr02= { 4,5,6 };
            //Console.WriteLine($"Arr01: { Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: { Arr02.GetHashCode()}");
            // /*Any object consisits of:
            //  *1.Identity[Address]
            //  *2.Object state[Data]
            //  */

            //Console.WriteLine();
            //Arr02 = Arr01;//Shallow copy
            ////{1,2,3}==>Has two references
            ////{4,5,6}==>Is unreachable object
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Arr01[0] = 100;
            //Console.WriteLine($"Arr02[0]: {Arr02[0]}");
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine();
            //Arr02 = (int[])Arr01.Clone();//Deep copy
            ////CLone will clone the object state(Data) of caller
            ////Assign the new object to Arr02 and genrate new IDENTITY
            ////
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            /*Ant object consists of:
              1.Object state(data)
              2.Identity(Address)
             */
            //Arr01[0] = 100;
            //Console.WriteLine($"Arr02[0]: {Arr02[0]}");
            //string[] Arr01 = { "Ahmed", "Omar", "Ali" };
            //string[] Arr02 = { "Zyad", "Adel", "Amr" };
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine();

            ////Arr02 = Arr01;//Shallow copy
            //Arr02 = (string[])Arr01.Clone();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine();
            //Arr01[0] = "Ahmed Amin";
            //Console.WriteLine($"Arr02[0]: {Arr02[0]}");

            //StringBuilder[] Arr01 =
            //{
            //    new StringBuilder("Ahmed"),
            //    new StringBuilder("Ali"),
            //    new StringBuilder("Omar"),

            //};
            //StringBuilder[] Arr02 =
            //{
            //    new StringBuilder("Amr"),
            //    new StringBuilder("Adel"),
            //    new StringBuilder("Zyad"),

            //};
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine();

            //Arr02 = (StringBuilder[])Arr01.Clone();
            //Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            //Console.WriteLine();
            //Arr02[0].Append(" Amin");
            //Console.WriteLine($"Arr01[0]: {Arr01[0]}");
            #endregion
            #region Video06 IClonable
            Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 30, Salary = 12000 };
            Employee E02 = new Employee() { Id = 2, Name = "Amr", Age = 32, Salary = 11000 };

            //E02 = E01;//Shallow copy
            //E02 = (Employee)E01.Clone();//Deep Copy
            //E02 = new Employee(E01);//Deep copy copy constructor
            //E02 = (Employee)E01.Clone();
            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
            //E01.Salary = 5;
            //Console.WriteLine(E01);
            //Console.WriteLine(E02);
            #endregion

        }
    }
}
