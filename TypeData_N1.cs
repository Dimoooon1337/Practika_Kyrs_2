
using System;
using System.Text;

Console.WriteLine(CalculateCompoundInterest(1000, 3, 10));

/// <summary>
/// Рассчитывает сложные проценты по годам.
/// </summary>
/// <param name="initialDeposit">
/// Начальная сумма вклада.
/// </param>
/// <param name="years">
/// Количество лет.
/// </param>
/// <param name="interestRate">
/// Годовая процентная ставка.
/// </param>
/// <returns>
/// Строка с накоплениями за каждый год.
/// </returns>
static string CalculateCompoundInterest(
    double initialDeposit,
    int years,
    double interestRate)
{
    // Проверяем корректность входных данных.
    if (initialDeposit <= 0 || years <= 0 ||
        interestRate <= 0)
    {
        throw new ArgumentOutOfRangeException(
            nameof(initialDeposit),
            "Все значения должны быть положительными.");
    }

    // Создаём строку для результатов.
    var result = new StringBuilder();

    // Сохраняем первоначальную сумму вклада.
    double amount = initialDeposit;

    // Рассчитываем проценты за каждый год.
    for (int year = 1; year <= years; year++)
    {
        // Начисляем проценты на накопленную сумму.
        amount *= 1 + interestRate / 100;

        // Добавляем результат с двумя знаками.
        result.AppendLine(
            $"Год {year}: {amount:F2} руб.");
    }

    // Возвращаем готовую строку.
    return result.ToString();
}
