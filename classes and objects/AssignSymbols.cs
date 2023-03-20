namespace exercisesCSharp.easy.classes_and_objects;

public class AssignSymbols
{
    private char _symbols;
    private string? _txt;

    private void AssignValue(char s) => Console.WriteLine($"Symbols field: {_symbols = s}");
    private void AssignValue(string txt) => Console.WriteLine($"String field: {_txt = txt}");

    private void AssignValue(char[] arraySymbs)
    {
        if (arraySymbs.Length > 1)
        {
            // foreach (var t in symbs) someTxt += Convert.ToString(t);
            // we can covert it to linq expression
            string someTxt = arraySymbs.Aggregate("", (current, t) => current + Convert.ToString(t));
            AssignValue(someTxt);
        }
        else
        {
            var oneSymb = ' ';
            foreach (var z in arraySymbs) oneSymb = Convert.ToChar(z);
            AssignValue(oneSymb);
        }
    }


    static void Main()
    {
        var obj = new AssignSymbols();
        char[] symbolsArray = { 'e' };
        char[] anotherSymbolsArray = { 'M', 'o', 'r', 'n', 'i', 'g' };
        
        obj.AssignValue('A');
        obj.AssignValue("Hello");
        
        obj.AssignValue(symbolsArray);
        obj.AssignValue(anotherSymbolsArray);
    }
}