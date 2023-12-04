// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд числа должен располагаться 
// на 0-м индексе массива, младший – на последнем. Размер массива должен быть 
// равен количеству цифр.

int number = new Random().Next(1, 100000);
Console.WriteLine(number);
int numLength = (int)Math.Floor(Math.Log10(number) + 1);
int[] array = new int[numLength];
    for(int i = numLength - 1; i >= 0; i--){
    array[i] = number % 10;
    number = number / 10;
}
Console.WriteLine("Массив цифр числа:");
        foreach (int digit in array)
        {
            Console.Write(digit + " ");
        }