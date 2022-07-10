//Задача 1: Задайте массив строк. Напишите программу, которая
//считает кол-во слов в массиве, начинающихся на гласную букву.

string text ="Two roads diverged in a yellow wood "
            +"And sorry I could not travel both "
            +"And be one traveler long I stood "
            +"And looked down one as far as I could "
            +"To where it bent in the undergrowth";

string [] poem = text.Split(new char[]{' '});
Console.WriteLine();
Console.WriteLine($"Количество слов, начинающихся на гласную букву равно {CountVowels(poem)}");

int CountVowels(string [] array)
{
    string vowels = "AaEeIiOoYyUu";
    int count  = 0;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (array[i][0] == vowels[j])
            count++;
        }
    }
    return count;
}

//Задача 2: Задайте массив строк. 
//Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

// string nameList = "Liam,Olivia,Noah,Emma,Oliver,Charlotte,Elijah,Amelia,James,Anna";
// string [] names = nameList.Split(new char[]{','});
// PrintArray(MergeElements(names));

// string[] MergeElements(string[] incomingArray)
// {
//     int size = incomingArray.Length / 2;
//     if (incomingArray.Length % 2 == 1) size +=1;
//     string[] pairs = new string[size];
//     if (incomingArray.Length % 2 == 1)
//     pairs[size-1] = incomingArray[incomingArray.Length-1];

//     int j = 0;
//     for (int i = 0; i < incomingArray.Length/2; i++)
//     { 
//         j = i * 2;
//         pairs[i] = incomingArray[j] +  " "  + incomingArray[j+1];
//     }
//     return pairs; 
// }
// void PrintArray(string[] array) 
// {
//     for(int i = 0; i < array.Length; i++)
//     Console.WriteLine(array[i] + " ");
// }
