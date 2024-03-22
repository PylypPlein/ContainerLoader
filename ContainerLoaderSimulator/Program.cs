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
     //menu tworzenia kontenera
     break;
    case 2:
     //menu wyboru oraz zaladowania kontenera
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
  Console.WriteLine("1 - stwórz kontener");
  Console.WriteLine("2 - zaladuj kontener");
  Console.WriteLine("0 - exit");
 }

 private static void ExitMessage()
 {
  Console.WriteLine("Do widzenia!");
 }
}