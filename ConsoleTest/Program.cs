using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;
using TestLibrary.Computer;
using TestLibrary.Inheritence;
using TestLibrary.Interface;
using TestLibrary.CustomException;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testmessage();

            //Queue();

            //Stack();

            //StackV2();

            //StackV3();

            //QueueV2(); 

            //QueueV3();

            //Inheritence();

            //Student();

            //AbstractExample();

            //Interface();

            CustomException();

            Console.ReadLine();
        }

        static void Inheritence()
        {
            GrandFather surya = new GrandFather("Surya");
            Father Chandra = new Father("Chandra", "Jung");
            Uncle Hari = new Uncle("Hari");
            Me Shyam = new Me("Shyam");

            //Console.WriteLine("Gran Father Details :");
            //Console.WriteLine(surya.FirstName);
            //Console.WriteLine(surya.LastName);

            //Console.WriteLine("Father's Detail :");
            //Console.WriteLine(Chandra.FirstName + " " + Chandra.MiddleName + " " + Chandra.LastName);

            //Console.WriteLine("Uncle's Detail :");
            //Console.WriteLine(Hari.FirstName + " " + Hari.LastName);

            //Console.WriteLine("My Details : ");
            //Console.WriteLine(Shyam.FirstName + " " + Shyam.MiddleName + " " + Shyam.LastName);


            Console.WriteLine(surya.ToString());
            Console.WriteLine(Chandra.ToString());
        }

        static void QueueTemplateFunction()
        {
            QueueTemplateV3<string> strque = new QueueTemplateV3<string>();
            strque.Enqueue("123");

            QueueTemplateV3<int> intque = new QueueTemplateV3<int>();
            //

           
        }

        static void Testmessage()
        {
            Test t = new Test();
            Console.WriteLine("From T Object");
           // Console.WriteLine("From Static "+Test.TestFunction());
            Console.WriteLine("From non static "+t.TestNonStatic());
            Test t1 = new Test();

            Console.WriteLine("From t1 object");
            //Console.WriteLine("From Static " + Test.TestFunction());
            Console.WriteLine("From non static " + t1.TestNonStatic());

        }

        static void Queue()
        {
            CustomQueue cq = new CustomQueue(20);
            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(30);

            Console.WriteLine(cq.Count);
            var tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cq.Dequeue();
            Console.WriteLine("After Dequeuing : ");
            tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cq.Enqueue(40);
            Console.WriteLine("After adding 40 : ");
            tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }
        static void QueueV2()
        {
            CustomQueueV2 cs = new CustomQueueV2();
            for (int i = 0; i < 20; i++)
            {
                cs.Enqueue(i * 10);
            }

            var tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Dequeue();
            cs.Dequeue();
            Console.WriteLine("After Dequeuing :");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Enqueue(40);
            Console.WriteLine("After Enqueuing 40 : ");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }

        static void QueueV3()
        {
            CustomQueueV3 cs = new CustomQueueV3();
            for (int i = 0; i < 20; i++)
            {
                cs.Enqueue(i * 10);
            }

            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Dequeue();
            cs.Dequeue();
            Console.WriteLine("After Dequeue :");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Enqueue(40);
            Console.WriteLine("After Enqueue 40 : ");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }
        }
    

    static void Stack()
        {
            CustomStack cs = new CustomStack();
            cs.Push(10);
            
            var tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }

        static void StackV2()
        {
            CustomStackV2 cs = new CustomStackV2();
            for (int i = 0; i < 20; i++)
            {
                cs.Push(i * 10);
            }

            var tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }
        static void StackV3()
        {
            CustomStackV3 cs = new CustomStackV3();
            for (int i = 0; i < 20; i++)
            {
                cs.Push(i * 10);
            }

            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }
        }

        static void Student()
        {
            List<Subject> sub = new List<Subject>();
            sub.Add(new Subject() { SubjectName = "Math", TheoryMarks = 40, PracticalMarks = 15, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Nepali", TheoryMarks = 30, PracticalMarks = 13, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Science", TheoryMarks = 45, PracticalMarks = 18, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Social", TheoryMarks = 44, PracticalMarks = 16, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Enlish", TheoryMarks = 43, PracticalMarks = 12, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Computer", TheoryMarks = 47, PracticalMarks = 12, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Optional Math", TheoryMarks = 45, PracticalMarks = 13, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Account", TheoryMarks = 49, PracticalMarks = 12, FullMarks = 100 });

            Students st = new Students("Test Student", 123, sub);
            
            Console.WriteLine(st.Name+" "+st.Total+" "+st.Percentage+" "+st.Division);

            sub.Clear();
            sub.Add(new Subject() { SubjectName = "Math", TheoryMarks = 60, PracticalMarks = 15, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Nepali", TheoryMarks = 30, PracticalMarks = 13, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Science", TheoryMarks = 45, PracticalMarks = 18, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Social", TheoryMarks = 64, PracticalMarks = 16, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Enlish", TheoryMarks = 63, PracticalMarks = 12, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Computer", TheoryMarks = 57, PracticalMarks = 12, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Optional Math", TheoryMarks = 45, PracticalMarks = 13, FullMarks = 100 });
            sub.Add(new Subject() { SubjectName = "Account", TheoryMarks = 59, PracticalMarks = 12, FullMarks = 100 });

            st.Subject = sub;

            Console.WriteLine(st.Name + " " + st.Total + " " + st.Percentage + " " + st.Division);

        }

        static void AbstractExample()
        {

            for (int i = 0; i < 3; i++)
            {
                var tmps1 = GetVehicle(i);
                tmps1.Run();
                tmps1.NumberofTyres();

                Console.WriteLine("After casting : ");
                if (tmps1.GetType() == typeof(TestLibrary.Bike))
                {
                    var tmp = (TestLibrary.Bike)tmps1;
                    tmp.Run();
                    tmp.NumberofTyres();
                    tmp.Steer();
                }

                if (tmps1.GetType() == typeof(Car))
                {
                    var tmp = (Car)tmps1;
                    tmp.Run();
                    tmp.NumberofTyres();
                    
                }

                if (tmps1.GetType() == typeof(TestLibrary.Bus))
                {
                    var tmp = (TestLibrary.Bus)tmps1;
                    tmp.Run();
                    tmp.NumberofTyres();
                }

            }

            //var tmp1 = GetVehicle(1); // car
            //var tmp2 = GetVehicle(2); // bike
            //var tmp3 = GetVehicle(3); // bus

            
            

            //Console.WriteLine("Car");
            //tmp1.Run();
            //tmp1.NumberofTyres();

            //Console.WriteLine();
            //Console.WriteLine("Bike before casting");

            //tmp2.Run();
            //tmp2.NumberofTyres();

            //Console.WriteLine();
            //Console.WriteLine("Bus");

            //tmp3.Run();
            //tmp3.NumberofTyres();

            //Console.WriteLine();
            //Console.WriteLine("Bike after casting");

            //if (tmp1.GetType() == typeof(Bike))
            //{
            //    var tmp = (Bike)tmp1;
            //    tmp.Run();
            //    tmp.NumberofTyres();
            //    tmp.Steer();
            //}

            //if (tmp2.GetType() == typeof(Bike))
            //{
            //    var tmp = (Bike)tmp2;
            //    tmp.Run();
            //    tmp.NumberofTyres();
            //    tmp.Steer();
            //}

            //if (tmp3.GetType() == typeof(Bike))
            //{
            //    var tmp = (Bike)tmp3;
            //    tmp.Run();
            //    tmp.NumberofTyres();
            //    tmp.Steer();
            //}

        }

        static Vehicle GetVehicle(int i)
        {
            if (i%3==0)
            {
                return new TestLibrary.Bus();
            }
            else if(i%3==1)
            {
                return new Car();
            }
            else
            {
                return new TestLibrary.Bike();
            }

        }

        static void Interface()
        {
            car c = new car();
            TestLibrary.Interface.Bike b = new TestLibrary.Interface.Bike();
            Vehicles v = (Vehicles)c;

            v.PrintVal();

            v = (Vehicles)b;

            v.PrintVal();

            TestLibrary.Interface.Bus bus = new TestLibrary.Interface.Bus();
            Vehicle1 v1 = (Vehicle1)bus;

            v1.PrintData();

            v1 = (Vehicle1)c;

            v1.PrintData();

            TestInterface t = (TestInterface)b;
            t.test();

            t = (TestInterface)bus;
            t.test();

            Common com = (Common)c;
            com.run(12);
            com = (Common)b;
            com.run(14);
            com = (Common)bus;
            com.run(50);

        }


        static void Divide(int a, int b)
        {
            try
            {
                Console.WriteLine(MyExceptionExample.Divide(a,b ));
            }
            catch (Divideby5Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void CustomException()
        {
            Divide(10, 5);
            Divide(10, 10);
            Divide(10, 0);
        }
    }
}










