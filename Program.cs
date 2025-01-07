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
      Console.WriteLine("Count finished! Returning to menu.");
      Thread.Sleep(2500);
      Menu();
    }

    static void PreStart(int time) {
      Console.Clear();

      Console.WriteLine("Ready");
      Thread.Sleep(1000);

      Console.WriteLine("Set");
      Thread.Sleep(1000);

      Console.WriteLine("Start");
      Thread.Sleep(1000);

      Start(time);
    }

    static void ExitApp() {
      Console.WriteLine("");
      Console.Clear();
      Console.WriteLine("Are you sure you want to exit this app?");
      Console.WriteLine("");
      Console.WriteLine("1 -> Yes");
      Console.WriteLine("2 -> No, go back");

      Console.WriteLine("----------/--------/--------");

      Console.WriteLine("Select one of the options above: ");
      short exitResult = short.Parse(Console.ReadLine());

      if (exitResult == 1) System.Environment.Exit(0);
      else Menu();
    }

    static void Menu() {
      Console.Clear();
      Console.WriteLine("Would you like the count to be done in minutes or seconds? Base your choice on the example below:");
      Console.WriteLine("'numeric value's (10s) -> To count 10 seconds");
      Console.WriteLine("'numeric value'm (1m) -> To count 1 minute");
      Console.WriteLine("'0s' or '0m' -> Exit app");

      Console.WriteLine("----------/--------/--------");

      Console.WriteLine("Input a value similar to one of the examples above: ");
      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));

      int timeTypeMultiplier = 1;

      if (type == 'm') timeTypeMultiplier = 60;
      if (time == 0) ExitApp();

      PreStart(time * timeTypeMultiplier);
    }
  }
}