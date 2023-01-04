namespace exercisesCSharp.medium.classes_and_objects;

public class Entity
{
    private Random _rnd = new Random();
    private int _max;
    private int _min;
    
    // first assignment of values to fields
    // the field _max is always greater than _min 
    public Entity()
    {
        _max = _rnd.Next(150, 200);
        _min = _rnd.Next(1, 150);
        Console.WriteLine($"Field values after the first assignment: max - {_max}, min - {_min}");
    }

    public void Method(int x)
    {
        Console.WriteLine($"\nMethod with one argument. Argument values: {x}");

        if (_max < x) _max = x;
        else if (_min > x) _min = x;
    }

    public void Method(int x, int n)
    {
        Console.WriteLine($"\nMethod with two arguments. Argument values: {x}, {n}");
        if (_max < x || _max < n) _max = Math.Max(x, n);
        else if (_min > x || _min > n) _min = Math.Min(x, n);

        #region One way of the solution

        /*if (_max < x)
        {
            _max = x;
            if (_max < n)
            {
                _max = n;
            }
        }
        else if (_min > x)
        {
            _min = x;
            if (_min > n)
            {
                _min = n;
            }
        }*/

        #endregion
    }

    public void Show() => Console.WriteLine($"Max value: {_max}, Min value: {_min}");

    static void Main()
    {
        Random rnd = new Random();
        Entity ent = new Entity();

        ent.Method(rnd.Next(1, 136));
        ent.Show();
        ent.Method(rnd.Next(1, 100), rnd.Next(1, 100));
        ent.Show();
    }
}