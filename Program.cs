
string[]arr = {"hello", "2","word",";-)"};

/*
// Первый вариант (метод).
string[] ChangeArrayToTreeSimbols(string[] arr)
{
    int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            arr[j] = arr[i];
            j++;
        }
    }
    string[] newArr = new string[j];
    for(int i = 0; i < j; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}
*/

// Второй вариант (метод)
string[] ChangeArrayToTreeSimbols(string[] arr)
{
    for( int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length > 3)
        {
            arr[i] = " ";
        } 
    }
    return arr;
}


void PrintArray(string[] newArr)
{
    for(int i = 0; i < newArr.Length; i++)
    {
        Console.Write(newArr[i] + "  ");
    }
}

PrintArray(arr);
Console.WriteLine();
PrintArray(ChangeArrayToTreeSimbols(arr));




// Второй вариант (без метода).
/*
for( int i = 0; i < arr.Length; i++)
{
    if(arr[i].Length > 3)
    {
        arr[i] = " ";
    } 
}
for( int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + "");
        
}

*/


