namespace Algoliath
{
    public class TimerUtility
    {

        public static async void DustyTimer(){

            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(10));
            while (await periodicTimer.WaitForNextTickAsync())
            {
                // Place function in here..
                //Console.WriteLine("Printing");
                System.Diagnostics.Debug.Print("Printing");

            }
        }

    }
}
