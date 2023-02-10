// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void RandArray(int[] collection, int lBound, int hBound)            //  метод наполняет массив случайными числами
{
    for (int i = 0; i < collection.Length; i++)
        collection[i] = new Random().Next(lBound, hBound);
}

Console.Clear();                                                    //  очистка консоли
Console.WriteLine("Введите количество элементов в массиве: ");      // ввод числа
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)                                                        // если отрицательное значение
    Console.WriteLine($"Число должно быть больше 0!");
else
    {
    int[] array = new int[num];                                     //  объявление массива
    RandArray(array,100,1000);                                      //  наполнение массива
    Console.WriteLine(String.Join(" ",array));                      //  вывод массива
    int evenCount = 0;                                              //  накопитель подсчета
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)                                      //  элемент массива - чётный
            evenCount++;
    Console.WriteLine($"Количество чётных чисел - {evenCount}");
    }