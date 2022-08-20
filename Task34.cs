// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество элементов массива:");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int [i];
int SumEv = 0;
int SumOdd = 0;
for (int count = 0; count < i; count++) {
    array[count] = new Random().Next(100, 1000);
}
for (int count = 0; count < i; count ++) {
    if (array[count] % 2 == 0) {
        SumEv += 1;
    }
    else {
        SumOdd += 1;
    }
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Количество четных элементов массива = {SumEv}");
Console.WriteLine($"Количество нечетных элементов массива = {SumOdd}");

