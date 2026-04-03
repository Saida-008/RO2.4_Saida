////Task1

//int[] numbers = { 3, 7, 2, 9, 5, 1 };

//int sum = 0;

//foreach (int num in numbers)
//{
//    sum += num;
//}

//Console.WriteLine("Sum = " + sum);

////Task 2.1
//int[] temps = { 12, -3, 45, 0, 28, -10, 33 }
//;

//Array.Sort(temps);

//int min = temps[0];
//int max = temps[temps.Length - 1];

//Console.WriteLine($"Min = {min}, Max = {max}");

////2.2
//int min = temps[0];
//int max = temps[0];

//foreach (int t in temps)
//{
//    min = Math.Min(min, t);
//    max = Math.Max(max, t);
//}

//Console.WriteLine($"Min = {min}, Max = {max}");

////Task3.1
//string[] words = { "apple", "banana", "cherry", "date" };

//for (int i = 0; i < words.Length / 2; i++)
//{
//    string temp = words[i];
//    words[i] = words[words.Length - 1 - i];
//    words[words.Length - 1 - i] = temp;
//}

//Console.WriteLine(string.Join(" ", words));

////3.2
//string[] words2 = { "apple", "banana", "cherry", "date" };

//Array.Reverse(words2);

//Console.WriteLine(string.Join(" ", words2));

////Task4
//int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 }
//;

//int even = 0;
//int odd = 0;

//foreach (int num in data)
//{
//    if (num % 2 == 0)
//        even++;
//    else
//        odd++;
//}

//Console.WriteLine($"Even = {even}, Odd = {odd}");

////Task5
//int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };

//List<int> unique = new List<int>();

//foreach (int num in raw)
//{
//    if (!unique.Contains(num))
//    {
//        unique.Add(num);
//    }
//}

//Console.WriteLine(string.Join(" ", unique));

////Task6
//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//int k = 3;

//int[] result = RotateLeft(arr, k);

//Console.WriteLine(string.Join(" ", result));

//static int[] RotateLeft(int[] arr, int k)
//{
//    int n = arr.Length;
//    int[] rotated = new int[n];

//    k = k % n; // handle k > n

//    for (int i = 0; i < n; i++)
//    {
//        rotated[i] = arr[(i + k) % n];
//    }

//    return rotated;
//}