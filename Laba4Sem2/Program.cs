using Laba4Sem2;

public class Program
{
    public static void Main(string[] args)
    {
        /*
         *  Чтобы свойство не отображалось достаточно над ним повесить атрибут [DisplayAtr(false)],
         *  А чтобы свойство отобразилось не нужно писать ничего. Так как атрибут будет нулл и по проверке в методе ShoulDisplayProperty
         *  будет отображаться. Это позволяет не писать [DisplayAtr(true)] над каждым свойством которое нужно выводить.
         */
        var aboba = new List<object>
        {
            new Bitcoin("1LdoqW6GcbK3nQWYWEAfNKGXMPAg3anf9",100,true),
            new ThetherUS("0x93fba661e4160c77d3fac8ce84d4468d96cdc117","BSC",100,false),
        };
        ConsoleReporting consoleReporting = new ConsoleReporting(aboba);
        consoleReporting.Render();
    }
}
