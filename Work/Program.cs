// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.

void PrintArray(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
int LengthValidArray(string[] arr, int symbolSize)
{
    int len = arr.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (arr[i].Length <= symbolSize) count++;
    }
    return count;
}
string[] GetValidArray(string[] arrayInput, int size, int symbolLength)
{
    int length = arrayInput.Length;
    int index = 0;

    string[] newArray = new string[size];

    for (int i = 0; i < length; i++)
    {
        if (arrayInput[i].Length <= symbolLength)
        {
            newArray[index] = arrayInput[i];
            index++;
        }
    }
    return newArray;
}
string[] array = new string[] { "hel", "*556544", "fasfds", "4" };
int stringLength = 3;
PrintArray(array);
Console.WriteLine();
int sizeValidArray = LengthValidArray(array, stringLength);
string[] newArray = GetValidArray(array, sizeValidArray, stringLength);
Console.WriteLine("Valid array: ");
PrintArray(newArray);