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

        }
    }
}
