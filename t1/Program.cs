void ShowNumbers(int numbers)
{
    if (numbers == 0)
    {
        return;
    }
    if (numbers % 2 == 0)
    {
        ShowNumbers(numbers - 2);
        System.Console.Write(numbers + " ");
    }
    if (numbers % 2 == 1)
    {
        int numbers1 = numbers - 1;
        ShowNumbers(numbers1);
        System.Console.Write(numbers + " ");
    }
}
ShowNumbers(13);