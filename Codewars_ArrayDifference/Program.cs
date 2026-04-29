
Console.WriteLine("Codewars: Computing Difference between arrays !");
//int[] a = new int[2] {1, 2}; // {1, 2, 2, 2, 3}
//int[] b = new int[1] {1};    // {1, 3}

int[] a = new int[5] {1, 2, 2, 2, 3};
int[] b = new int[1] {2};
int count = 0;
for(int i=0; i < a.Length; i++)
{
    bool isFound = false;
    for(int j=0;j< b.Length; j++)// 
    {
        if (a[i] == b[j])
        {
            isFound = true;
            break;
        }
    }
    if (isFound == false)
    {
        count++;
    }
}

Console.WriteLine($"Number of elements Not Matched: {count}");
int currentIndex = 0;
int[] result = new int[count];
for (int i = 0; i < a.Length; i++)
{
    bool isFound = false;
    for (int j = 0; j < b.Length; j++)// 
    {
        if (a[i] == b[j])
        {
            isFound = true;
            break;
        }
    }
    if (isFound == false)
    {
        result[currentIndex] = a[i];
        currentIndex++;
    }
}

//Console.WriteLine(result); 


    Console.WriteLine(string.Join(", ", result));
Console.ReadKey();
