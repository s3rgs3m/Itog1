// https://github.com/s3rgs3m/Itog1
Console.Clear();
Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
String[] Arr = {"123","тест","три","-546",":-О","последний", "22"};
Console.WriteLine("Начальный массив: 123, тест, три, -546, :-О, последний, 22");
String[] Result=new String[Arr.Length];
int cnt = 0;
for (int i=0; i<Arr.Length;i++)
    if (Arr[i].Length<=3){
        Result[cnt] = Arr[i];
        cnt=cnt+1;
    }

Console.Write("Получившийся массив: ");
foreach (var item in Result)
{
    if (item is not null) Console.Write(item + " ") ;    
}

