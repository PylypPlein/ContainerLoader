
// See https://aka.ms/new-console-template for more information
/*
 * @author s24675
 */

public class Program
{
 public static void Main(String[] args)
 {
  int choose;
  do
  {
   ShowMainMenu();
   choose = Convert.ToInt32(Console.ReadLine());
   if (choose == 0)
   {
    break;
   }
   switch (choose)
   {
    case 1:
     //baza statkow
     ShowShipsMenu();
     choose = Convert.ToInt32(Console.ReadLine());
     switch (choose)
     {
      case 1:
       break;
      case 2:
       break;
      case 3:
       break;
      case 4:
       break;
      default:
       break;
     }
     break;
    case 2:
     //baza kontenerów
     ShowCargosMenu();
     choose = Convert.ToInt32(Console.ReadLine());
     switch (choose)
     {
      case 1:
       break;
      case 2:
       break;
      case 3:
       break;
      case 4:
       break;
      default:
       break;
     }
     break;
    default:
     Console.WriteLine("Wybierz dostępną opcje!");
     break;
   }
   {
    
   }
  } while (choose != 0);
  ExitMessage();
 }

 private static void ShowMainMenu()
 {
  Console.WriteLine("Container loader app v1.0");
  Console.WriteLine("1 - baza statków");
  Console.WriteLine("2 - baza kontenerów");
  Console.WriteLine("0 - exit");
 }

 private static void ShowShipsMenu()
 {
  Console.WriteLine("1 - stwórz statek");
  Console.WriteLine("2 - zaladuj statek");
  Console.WriteLine("3 - lista statkow");
  Console.WriteLine("4 - cofnij");
 }

 private static void ShowCargosMenu()
 {
  Console.WriteLine("1 - stwórz kontener");
  Console.WriteLine("2 - zaladuj kontener");
  Console.WriteLine("3 - lista kontenerów");
  Console.WriteLine("4 - cofnij");
 }

 private static void ExitMessage()
 {
  Console.WriteLine("Do widzenia!");
 }
}