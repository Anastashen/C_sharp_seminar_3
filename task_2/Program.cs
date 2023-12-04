// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
Random rand = new Random();

for(int i = 0; i < array.Length; i++){
    array[i] = rand.Next(1, 10);
}
Console.WriteLine(string.Join(" ", array));

int evenNum = 0;

for(int i = 0; i < array.Length; i++){
    if(array[i] % 2 == 0){
        evenNum = evenNum + 1;
    }
}

Console.WriteLine($"количество четных чисел: {evenNum}");