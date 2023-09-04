namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Der User soll angeben können, wieviele Zahlen der Fibonacci-Folge er berechnet haben möchte. 
            //Gib in der Konsole dann die entsprechenden Fibonacci-Zahlen aus.
            //Die Fibonacci-Folge beginnt mit den Zahlen 0 und 1. Jede weitere Zahl ergibt sich, in dem man die beiden vorherigen Zahlen zusammenzählt. 
            //Als Beispiel die ersten zehn Zahlen:
            //0 1 1 2 3 5 8 13 21 34

            Console.WriteLine("Wie viele Zählen der Fibonacci-Folge möchtest du berechnet haben?");
            string userZahlString = Console.ReadLine();
            int userZahl = Convert.ToInt32(userZahlString);

            ulong j = 0;
            ulong k = 1;

            for (int i = 0; i < userZahl; i++)
            {
                Console.WriteLine(j);
                Thread.Sleep(1000);

                k = j + k;
                j = k - j;
            }
        }
    }
}