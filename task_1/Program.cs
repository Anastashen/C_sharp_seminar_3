// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество 
// элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
Random rand = new Random();
for(int i = 0; i < array.Length; i++){
    array[i] = rand.Next(1, 100);
}
Console.WriteLine(string.Join(" ", array));

int amount = 0;

for(int i = 0; i < array.Length; i++){
    if(array[i] > 20 && array[i] < 90){
        amount = amount + 1;
    }
}
Console.WriteLine($"количество элементов: {amount}");