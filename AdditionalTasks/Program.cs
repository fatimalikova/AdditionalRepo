namespace AdditionalTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 (money)
            //int money = 234;

            //int m1 = 1;
            //int m2 = 5;
            //int m3 = 10;
            //int m4 = 20;
            //int m5 = 50;
            //int m6 = 100;


            //if (money >= m6)
            //{
            //    Console.WriteLine($"You can buy {money / m6} items of {m6}");
            //    money = money % m6;
            //}
            //if (money >= m5)
            //{
            //    Console.WriteLine($"You can buy {money / m5} items of {m5}");
            //    money = money % m5;
            //}
            //if (money >= m4)
            //{
            //    Console.WriteLine($"You can buy {money / m4} items of {m4}");
            //    money = money % m4;
            //}
            //if (money >= m3)
            //{
            //    Console.WriteLine($"You can buy {money / m3} items of {m3}");
            //    money = money % m3;
            //}
            //if (money >= m4)
            //{
            //    Console.WriteLine($"You can buy {money / m4} items of {m4}");
            //    money = money % m4;

            //}
            //if (money >= m2)
            //{
            //    Console.WriteLine($"You can buy {money / m2} items of {m2}");
            //    money = money % m2;
            //}

            //if (money >= m1)
            //{
            //    Console.WriteLine($"You can buy {money / m1} items of {m1}");
            //    money = money % m1;
            //} 
            #endregion

            #region Task2 (control of password)
            //string password = "Fatimaalik";

            //bool hasUpper = false;
            //bool hasLower = false;
            //bool hasDigit = false;
            //bool hasSpecial = false;
            //if (password.Length < 8)
            //{
            //    Console.WriteLine("Length of Password must be min 8");
            //    return;
            //}
            //else
            //{
            //    foreach (char ch in password)
            //    {
            //        if (char.IsUpper(ch)) hasUpper = true;
            //        else if (char.IsLower(ch)) hasLower = true;
            //        else if (char.IsDigit(ch)) hasDigit = true;
            //        else hasSpecial = true;

            //    }
            //    if (hasUpper && hasLower && hasDigit && hasSpecial && password.Length >= 8)  Console.WriteLine("Strong Password");
            //    else Console.WriteLine("Weak Password");


            //} 
            #endregion

            #region Task3 (en uzun sozu ekrana cixarir)
            //string sentence = "Hellooo World";
            //string[] words = sentence.Split(' ');
            //int count = 0;
            //string longestWord = "";

            //foreach (string word in words)
            //{
            //    if(word.Length > count)
            //    {
            //        count = word.Length;
            //        longestWord = word;
            //    }
            //}
            //Console.WriteLine(longestWord); 
            #endregion

            #region Task4 (money exchange)
            //double money = 234.0;
            //Console.WriteLine($"USD {money * 1.7}");
            //Console.WriteLine($"EURO {money * 1.9}");
            //Console.WriteLine($"Try {money * 25}");
            #endregion

            #region Task5 (daily temp)
            //int[] temp = { 13, 45, 23, 16, 22, 36, 27 };
            //int avarage;
            //int sum  = 0;
            //int max = temp[0];
            //int min = temp[0];

            //for(int i = 0; i < temp.Length; i++)
            //{
            //    sum += temp[i];
            //    if (temp[i] < min)
            //    {
            //        min = temp[i];
            //    }
            //    else if (temp[i] > max)
            //    {
            //        max = temp[i];
            //    }
            //}
            //avarage = sum / temp.Length;
            //Console.WriteLine($"Avarage is {avarage}");
            //Console.WriteLine($"Max temperature is {max}");
            //Console.WriteLine($"Min temperature is {min}"); 
            #endregion

            #region Task6 (money of bus)
            //double price = 0.60;
            //int age = 20;
            //bool isStudent = true;
            //if (age < 6) price = 0; 
            //else if ((age < 18 && age > 6) || isStudent ) price = price * 0.5;
            //else if (age >= 60) price = price * 0.7;
            //else price = price;
            //Console.WriteLine(price); 
            #endregion

            #region Task7 (car)
            //int entertime = 4, exittime = 10,difference = exittime - entertime,fee = 2;
            //Console.WriteLine(difference * fee); 
            #endregion

            #region Task8 (en cox tekrarlanan soz)
            //string str = "hello hello hello bye World";
            //int count = 1;
            //string[] word = str.Split(' ');
            //for(int j = 0; j < word.Length; j++)
            //{
            //    if(word[j] == "")
            //        continue;
            //    for (int i = j + 1; i < word.Length; i++)
            //    {
            //        if(word[j] == word[i])
            //        {
            //            count++;
            //            word[j] = "";

            //        }

            //    }

            //}

            //Console.WriteLine(count); 
            #endregion

            #region Task8 (randomly number)
            //Random random = new Random();
            //int randomNumber = random.Next(1, 101);

            //int attempts = 0;
            //bool isGuessed = false;
            //Console.WriteLine("Welcome to the Number Guessing Game!");
            //int guess =Int32.Parse( Console.ReadLine());
            //while (!isGuessed)
            //{
            //    if (guess > randomNumber)
            //    {
            //        Console.WriteLine("Too high");
            //    }
            //    else if (guess < randomNumber)
            //    {
            //        Console.WriteLine("Too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Congratulations! You've guessed the number {randomNumber} in {attempts} attempts.");
            //        isGuessed = true;
            //    }
            //    attempts++;
            //    guess = Int32.Parse(Console.ReadLine());

            //} 
            #endregion

            //Bird bird = new Bird();
            //bird.Fly();
            //bird.eat();
            //Dog dog = new Dog();
            //dog.MakeSound();



            //Student student1 = new Student();
            //student1.name = "Fatima";
            //student1.adress = 1;
            //student1.age = 15;
            //student1.Phone = "333-56-3";
            //student1.GPA = 93.7;
            //student1.Study();

            //Student student2 = new Student();
            //student2.name = "Leila";
            //student2.adress = 2;
            //student2.age = 15;
            //student2.Phone = "23-422-3";
            //student2.GPA = 99.9;
            //student2.Study();



            //Console.WriteLine(student1.name);
            //Console.WriteLine(student2.name);
            //Console.WriteLine(student1.adress);
            //Console.WriteLine(student2.age);
            //Console.WriteLine(student2.Phone);
            //Console.WriteLine(student2.GPA);

            //Console.WriteLine("Sum:");
            //SumofArray(new int[] { 1, 2, 3, 4, 5 });


            //isSimple(0);
            ////Console.WriteLine(CountofPrimeNums(3,40));
            ////Console.WriteLine(OddNums(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3));

            //string str = "salam";
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.Contains("Sa", StringComparison.OrdinalIgnoreCase));



            //string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
            //int[] numbers = { 5, 2, 9, 1, 5, 6 };
            //double[] decimals = { 3.14, 1.59, 2.65, 5.35 };

            //DisplayArray(numbers);
            //DisplayArray(fruits);
            //DisplayArray(decimals);



            //string[] colors = new string[3];
            //colors[0] = "Red";
            //colors[1] = "Green";
            //colors[2] = "Blue";
            //Array.Resize(ref colors, 4);
            //colors[3] = "Yellow"; // This will throw an IndexOutOfRangeException

            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            List<string> colors = new List<string>();
            colors.Add("Black");
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Yellow");
            colors.Add("Black");
            //colors.Remove("Green");

            //Console.WriteLine(colors.Count);
            //Console.WriteLine(colors.IndexOf("Blue"));
            //Console.WriteLine(colors.Contains("Blue"));
            //Console.WriteLine(colors.LastIndexOf("Black"));

            //colors.Insert(0, "Black");
            //colors.RemoveAt(2);
            //colors.Reverse();
            //colors.Sort();
            //colors.Clear();

            //string[] colorsArray = colors.ToArray();

            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            Car car = new Car();
            Boat boat = new Boat();
            Plane plane = new Plane();

            Vehicles[] vehicles = { car, boat, plane };
            foreach (Vehicles vehicle in vehicles)
            {
                vehicle.Start();
            }
        }



        public static void DisplayArray<T>(T[] item)
        {
            foreach (T i in item)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }


        private static int CountofPrimeNums(int n, int m)
        {
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                bool isPrime = true;
                if (i < 2) continue;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) count++;
            }
            return count;

        }

        private static int[] OddNums(int[] arr, int num)
        {
            int[] result = new int[num];
            int index = 0;
            foreach (int number in arr)
            {
                if (number % 2 != 0)
                {
                    result[index] = number;
                    index++;
                    if (index == num) break;
                }
            }
            return result;
        }

        public static void isSimple(int num)
        {
            bool isSimple = false;
            if (num < 2)
            {
                Console.WriteLine("this number neither simple nor complex");
                return;
            }
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isSimple = true;
                    break;
                }
            }
            if (!isSimple) Console.WriteLine("simple");
            else Console.WriteLine("complex");
        }


        public static void SumofArray(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }


        class Student
        {
            //Fields
            public string name;
            public int age;
            public int adress;
            public string Phone;
            public double GPA;


            public void Study()
            {
                Console.WriteLine(GPA);
            }
        }


    }

    abstract class Animal
    {
        public abstract void MakeSound();
        private void Sleep()
        {
            Console.WriteLine("Zzz...");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    interface IFlyable
    {
        void Fly();
        void eat();
    }
    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
        public void eat()
        {
            Console.WriteLine("The bird is eating.");
        }
    }

    public class Vehicles
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
    }
    public class Car : Vehicles
    {
        public override void Start()
        {
            Console.WriteLine("Car started with a roar!");
        }
    }


    public class Boat : Vehicles
    {
        public override void Start()
        {
            Console.WriteLine("Boat started with a splash!");
        }
    }

    public class Plane : Vehicles
    {
        public override void Start()
        {
            Console.WriteLine("Plane started with a roar and is taking off!");
        }
    }
}
