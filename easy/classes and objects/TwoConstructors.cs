// TODO-ru :  Напишите программу с классом, у которого есть символьное и целочисленное поле.
// В классе должны быть описаны версии конструктора с двумя аргументами (целое число и символ - определяют значения полей), а также с одним аргументом типа double.
// В последнем случае действительная часть аргумента определяет код символа (значение символьного поля), а дробная часть (с учетом десятых и сотых) определяет значение целочисленного поля.
// Например, если аргументом передается число 65.1267 , то значением символьного поля будет символ 'А' с кодом 65 , а целочисленное поле получит значение 12 (в дробной части учитываются только десятые и сотые). (on 12/22/2022, 11:43pm)

// TODO-en : Write a program with a class that has a character and an integer field.
// The class must describe versions of the constructor with two arguments (an integer and a symbol - determine the values of the fields), as well as with one argument of the double type.
// In the latter case, the real part of the argument determines the character code (the value of the character field), and the fractional part (including tenths and hundredths) determines the value of the integer field.
// For example, if the number 65.1267 is passed as an argument, then the value of the character field will be the character 'A' with the code 65 , and the integer field will receive the value 12 (only tenths and hundredths are taken into account in the fractional part). (on 12/22/2022, 11:43pm)

namespace exercisesCSharp.easy.classes_and_objects;

public class Project
{
    public char SymbolField;
    public int NumField;

    public Project(char s, int x)
    {
        SymbolField = s;
        NumField = x;
        Console.WriteLine($"Initial field values : {SymbolField}, {NumField}");
    }

    public Project(double x)
    {
        SymbolField = (char)(x);
        NumField = (int)(((decimal)x % 1) * 100);
        Console.WriteLine($"The resulting character from the floating number : {SymbolField}");
        Console.WriteLine($"The resulting integer number from tenths and hundredths : {NumField}");
    }

    static void Main()
    {
        Project dummy1 = new Project('S', 598);
        Project dummy = new Project(315.34);
    }
}