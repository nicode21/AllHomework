using Service.Services.Implementation;
using Service.Services.Interface;

namespace PolymorphismAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();

            //car1.Name = "sadasd";

            //Console.WriteLine(car1.Name);


            //Cat cat = new Cat();

            //cat.Name = "asdasdasd";

            //Console.WriteLine(cat.Sound());
            //cat.Sound();


            //Bird bird = new Bird();

            //    bird.Sound();


            //Animal animal = new Animal();

            //animal.Sound();


            //cat.Eat();         OVERLOADING


            //Student student = new Student();

            //student.Name = "asdasd";

            //    Student  student = new Student
            //    {
            //        Name = "asdasd",
            //        Surname = "sadasdasd",
            //        Age = 14
            //    };
            //    Console.WriteLine(GetStudent(student, 15)); 

            //}

            //public static Student GetStudent(Student student,int age)
            //{
            //    student.Age = age;

            //    return student;
            //}


            //Employee emp1 = new Employee();

            //emp1.Test2();


            //Car car = new Car();

            //IUser user1 = new User();

            //user1.Login("Salam","Aleykum");

            //Console.WriteLine(user1.SendEmail("asdasdad"));


            IAccountService service = new AccountServices();

            service.Register();
        }
    }
}
