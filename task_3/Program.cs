// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите 
// разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
Random rand = new Random();
for(int i = 0; i < array.Length; i++){
    array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
}
Console.WriteLine(string.Join(" ", array));

double max = array[0];
for(int i = 0; i < array.Length; i++){
    if(max < array[i]){
        max = array[i];
    }
}
Console.WriteLine($"max число: {max}");

double min = array[0];
for(int i = 0; i < array.Length; i++){
    if(min > array[i]){
        min = array[i];
    }
}
Console.WriteLine($"min число: {min}");

double diff = max - min;
Console.WriteLine($"Разница равна: {diff}");