// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 4

int SearchPositiveNumber(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] FillArrayWithRandomNumbers(int size)

{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)

    {
        System.Console.WriteLine("введите  цифру");

        arr[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine('[' + string.Join("| ", arr) + ']');

    return arr;
}

System.Console.WriteLine("введите количество предпологаемых цифр");

int elementCount = int.Parse(Console.ReadLine());

int[] arr = new int[elementCount];

int[] array = FillArrayWithRandomNumbers(elementCount);
int positivenumber = SearchPositiveNumber(array);

System.Console.WriteLine($"Количество цифр больше нуля = {positivenumber}");