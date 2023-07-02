string [] array = new string [5] {"123","176545","-1","Rus","-30045"};
string [] array1 = new string [array.Length];

void NewArray(string[]array, string[]array1)
{
    int count = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if(array[i].Length <=3)
        {
            array1[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[]array2)
{
    for (int i = 0; i <array2.Length; i++)
     {
        Console.Write(array2[i]+" , ");//из за запятой в ковычках в ответе выходят все числа, подскажите как сделать чтобы выводилось только нужные данные?
     }
    Console.WriteLine();
}
NewArray(array,array1);
PrintArray(array1);