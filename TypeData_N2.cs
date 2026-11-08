
PrintDiamond(5);

/// <summary>
/// Выводит пустой внутри ромб из символов X.
/// </summary>
/// <param name="size">
/// Длина диагоналей ромба.
/// Положительное нечётное число.
/// </param>
static void PrintDiamond(int size)
{
    // Проверяем корректность размера ромба.
    if (size <= 0 || size % 2 == 0)
    {
        Console.WriteLine("Размер должен быть положительным нечётным числом.");
        return;
    }

    // Определяем индекс центральной строки.
    int center = size / 2;

    // Последовательно перебираем строки ромба.
    for (int row = 0; row < size; row++)
    {
        // Вычисляем расстояние от текущей строки до центра.
        int distance = Math.Abs(center - row);

        // Определяем позиции левой и правой границ ромба.
        int left = distance;
        int right = size - distance - 1;

        // Перебираем все позиции текущей строки.
        for (int column = 0; column < size; column++)
        {
            // Выводим X только на границах ромба.
            if (column == left || column == right)
            {
                Console.Write('X');
            }
            else
            {
                // Оставляем внутреннюю часть ромба пустой.
                Console.Write(' ');
            }
        }

        // Переходим на следующую строку.
        Console.WriteLine();
    }
}
