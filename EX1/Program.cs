string[] array1 = new string[] { "1995", "happy", "lol", "gb33", "leo", "-23333", "59888" };
string s1 = string.Join(", ", array1);
System.Console.WriteLine($"[{s1}]");

int size = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3) size++;
}

string[] array2 = new string[size];
    int k = 0;
        for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) 
        {
            array2[k] = array1[i];
            k++;
        }
    }

string s2 = string.Join(", ", array2);
System.Console.WriteLine($"[{s2}]");