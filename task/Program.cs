// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.


string[] array = {"hello", "2", "world", ":-)"};
string[] array1 = new string [array.Length];

string[] ReadString (string[] massive)
{
    int count = 0;
 for(int i = 0; i < massive.Length; i++)
 {
 if(massive[i].Length <= 3)
   {
   array1[count] = massive[i];
   count++;
   }
 }
 return array1;
}

string[] result = ReadString(array);