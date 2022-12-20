string[] array1 = new string[] { "1995", "happy", "lol", "gb33", "leo", "-23333", "59888" };
string s1 = string.Join(", ", array1);
System.Console.WriteLine($"[{s1}]");

int size = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3) size++;
}
System.Console.WriteLine(size);