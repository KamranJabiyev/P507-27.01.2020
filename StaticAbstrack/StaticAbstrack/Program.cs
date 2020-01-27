using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAbstrack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //Area area = new Area();
            //area.Length = 100;
            //area.Width = 200;
            //area.AreaK();
            #endregion

            #region Static
            //Person p2 = new Person("Mubush", "Memmedzade");
            //Person p1 = new Person("Sadiq","Eliyev");
            //Console.WriteLine(p2.GetId());
            //Console.WriteLine(p1.GetId());
            //Console.WriteLine(Student.MyProperty);
            #endregion

            #region Abstract,Sealed
            //Eagle eagle = new Eagle();
            //eagle.Test();
            //eagle.Eat();

            //Snake snake = new Snake();
            #endregion
            //int[] z = { 1, 4, 5 };
            //Person[] arrPerson = { p1, p2, p3 };
            //int[] arrInt=new int[5];
            //Console.WriteLine(arrInt.Length);
            //Array.Resize(ref arrInt, arrInt.Length+1);
            //Console.WriteLine(arrInt.Length);
            //arrInt[5] = 5;
            Person p1 = new Person("Sadiq", "Eliyev");
            Person p2=new Person("Fazil", "Axundov");
            Person p3 = new Person("Mubush", "Memmedzade");

            PersonList list = new PersonList();
            list.Append(p1);
            list.Append(p2);
            list.Append(p3);

            list.GetAllList();


        }
    }

    #region Static
    //class Person
    //{
    //    private static int Id = 0;
    //    public string Name = "Imran";
    //    private int _id;
    //    public string Surname { get; set; }

    //    static Person()
    //    {
    //        Console.WriteLine("Ilk insan doguldu");
    //    }

    //    public Person()
    //    {
    //        Id++;
    //        _id = Id;
    //    }

    //    public Person(string name,string surname):this()
    //    {
    //        Name = name;
    //        Surname = surname;
    //    }

    //    public int GetId()
    //    {
    //        return _id;
    //    }

    //    public override string ToString()
    //    {
    //        Test();
    //        return $"{Name} {Surname}";
    //    }

    //    public static void Test()
    //    {
    //        //Person p = new Person("Fazil","Axundow");
    //        //p.ToString();
    //        Console.WriteLine("Bu bir insandir");
    //    }
    //}
    //static class Student
    //{
    //    static Student()
    //    {
    //        Console.WriteLine("First Student");
    //    }
    //    public static int MyProperty = 10;

    //    public static int Test()
    //    {
    //        return 5;
    //    }
    //}
    #endregion

    #region Abstract,Sealed
    //abstract class Animal
    //{
    //    //public Animal(string s)
    //    //{

    //    //}
    //    public abstract void Eat();
    //    public int MyProperty { get; set; }
    //    public virtual void Test()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}

    //abstract class Bird:Animal { }

    //class Eagle : Bird
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eat as Eagle");
    //    }
    //}


    //sealed class Snake : Animal
    //{
    //    public override void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Elephant{ }
    #endregion

}
