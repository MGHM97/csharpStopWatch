using System;
using System.Threading;

namespace csharpStopWatch {
  class Program {
    static void Main (string[] args) {
      Menu();
    }

    static void Start(int time) {
      int currentTime = 0;

      while (currentTime != time) {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);

        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("Count finished. Returning to menu");
      Thread.Sleep(2500);
      Menu();
    }

    static void Menu() {
      Console.Clear();
      Console.WriteLine("Would you like the count to be done in minutes or seconds? Base your choice on the example below:");
      Console.WriteLine("'numeric value's (10s) -> To count 10 seconds");
      Console.WriteLine("'numeric value'm (1m) -> To count 1 minute");
      Console.WriteLine("'0s' or '0m' -> Exit app");

      Console.WriteLine("----------/--------/--------");

      Console.WriteLine("Select one of the options above: ");
      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));

      int timeTypeMultiplier = 1;

      if (type == 'm') timeTypeMultiplier = 60;
      if (time == 0) System.Environment.Exit(0);

      Start(time * timeTypeMultiplier);
    }
  }
}