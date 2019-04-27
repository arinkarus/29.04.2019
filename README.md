## String
- [referencesource.String ](https://referencesource.microsoft.com/#mscorlib/system/string.cs,8281103e6f23cb5c)
- [Особенности строк в .NET](https://habr.com/ru/post/172627/)
- [String.Intern делает строки ещё интереснее](https://habr.com/ru/post/224281/)
- [Строки в C# и .NET](https://habr.com/ru/post/165597/)
- [Строки, неизменяемость и персистентность. Невероятные приключения в коде. Перевод блога Эрика Липперта](https://blogs.msdn.microsoft.com/ruericlippert/2011/08/08/653/)

## StringBuilder
- [StringBuilder прошлое и настоящее](https://habr.com/ru/post/172689/)
- [referencesource.StringBuilder](https://referencesource.microsoft.com/#mscorlib/system/text/stringbuilder.cs,adf60ee46ebd299f)

# 29.04.2019 (deadline - 12.00)

- Реализовать метод, который принимает на вход строку **source** и количество итераций **count**.

          public string Convert(string source, int count)

  На каждой итерации метода объединяются нечетные символы строки и переносятся в ее начало, а четные символы – в конец.
  
  > Пример (строка «Привет Епам!»): 
  >    
  > 1 итерация:  «Пие пмрвтЕа!»    
  > 2 итерация: «Пепртаи мвЕ!»    
  > ...

   Результат работы метода – результат склеек символов через count итераций.

   При реализации алгоритма учесть, что входная строка может содержать очень большое количество символов, а количество итераций может быть огромным. Оптимизировать код с точки зрения быстродействия и потребления ресурсов.

   Проверить аргументы на валидность:
   - Запрещается передавать пустые строки, строки из пробелов, null.
   - Количество итераций должно быть больше 0.

   При нарушении этих условий метод генерирует исключение.

   Проверить работу метода с помощью модульных тестов (nUnit).
