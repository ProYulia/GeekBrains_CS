// Работа с текстом. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы к большими,
//большие с заменить маленькими.

/*
string text = "Папы, мамы и тети Нади нет дома. Они уехали на крестины к тому старому офицеру, "
+ "который ездит на маленькой серой лошади. В ожидании их возвращения Гриша, Аня, Алеша, Соня и кухаркин сын Андрей "
+ "сидят в столовой за обеденным столом и играют в лото. Говоря по совести, им пора уже спать; но разве можно уснуть, "
+ "не узнав от мамы, какой на крестинах был ребеночек и что подавали за ужином.";

// string s = "qwerty";
//             012345
// s[3] // e

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;
  
  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
  if (text[i] == oldValue) result = result + $"{newValue}";
  else result = result + $"{text[i]}";
  }
  return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine();
newText = Replace(newText, 'С', 'с'); 

// Работа с массивом. Нужно отсортировать массив
// Используем алгоритм сортировки мин-макс

int [] arr = {1, 2, 4, 2, 6, 9, 1};
void PrintArray(int[] array)
{ 
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
  Console.Write($"{array[i]}");
  }
Console.WriteLine();
}
void SelectionSort(int[] array)
{
  
  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
    if (array[j] < array[minPosition]) minPosition = j;
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
