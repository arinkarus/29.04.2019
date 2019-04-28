## Encoding
- [Юникод и .NET](https://m.habr.com/ru/post/193048/) - **обязательна к прочтению!**

## String
- [referencesource.String ](https://referencesource.microsoft.com/#mscorlib/system/string.cs,8281103e6f23cb5c)
- [Особенности строк в .NET](https://habr.com/ru/post/172627/) - **обязательна к прочтению!**
- [New Recommendations for Using Strings in Microsoft .NET 2.0](https://docs.microsoft.com/en-us/previous-versions/dotnet/articles/ms973919(v=msdn.10))
- [String.Intern делает строки ещё интереснее](https://habr.com/ru/post/224281/)
- [Строки в C# и .NET](https://habr.com/ru/post/165597/)
- [Строки, неизменяемость и персистентность. Невероятные приключения в коде. Перевод блога Эрика Липперта](https://blogs.msdn.microsoft.com/ruericlippert/2011/08/08/653/)

## StringBuilder
- [StringBuilder прошлое и настоящее](https://habr.com/ru/post/172689/) - **обязательна к прочтению!**
- [referencesource.StringBuilder](https://referencesource.microsoft.com/#mscorlib/system/text/stringbuilder.cs,adf60ee46ebd299f)

# 29.04.2019 (deadline - 12.00)

- Реализовать метод, который принимает на вход строку **source** и количество итераций **count** (проект *StringExtension*).

          public string Convert(string source, int count)

  На каждой итерации метода объединяются нечетные символы строки и переносятся в ее начало, и четные символы, которые переносяться в конец.
  
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

   Проверить работу метода с помощью модульных тестов (проект *StringExtension.Tests*), к предложенным тест кейсам добавить дополнительные.
   
   Проверить возможность работы разработанного метода с большими строками и большим количеством итераций (проект *StringExtensionWithFiles*), замерить время счета.
