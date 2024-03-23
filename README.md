# Описание работы и сути программы

```markdown
# Создаем исходный массив строк

```

```csharp
string[] inputArray = new string[] { "Hello", "2", "world", ":-)" };
string[] outputArray = new string[inputArray.Length];
int outputIndex = 0;

```

```markdown
# Добавлям новый массив для строк короче 3 символов строк

```

```csharp
foreach (string s in inputArray)
{
    if (s.Length <= 3)
    {
        outputArray[outputIndex++] = s;
    }
}

```

```markdown
# В конце выводим исходный и итоговый массив в консоль

```

```csharp
Console.WriteLine("Исходный массив:");
foreach (string s in inputArray)
{
    Console.Write($"{s} ");
}
Console.WriteLine();

Console.WriteLine("Итоговый массив:");
foreach (string s in outputArray)
{
    Console.Write($"{s} ");
}
Console.WriteLine();

```

## Программа создает два массива строк, затем проходит по каждому элементу исходного массива и добавляет строки, длина которых не превышает 3 символов, в новый массив. 
## В конце, она выводит оба массива на консоль.
