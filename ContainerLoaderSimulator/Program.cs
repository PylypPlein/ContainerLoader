
// See https://aka.ms/new-console-template for more information
/*
 * @author s24675
 */

using ContainerLoaderSimulator;

public class Program
{
 static ContainerList liquidContainersList = new ContainerList();
 static ContainerList gasContainersList = new ContainerList();
 static ContainerList productContainersList = new ContainerList();
 public static void Main(String[] args)
 {
  int choose;
  int index;
  int type;
  do{
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
     ShowCargosMenu();
     choose = Convert.ToInt32(Console.ReadLine());
     switch (choose)
     {
      case 1:
       Console.WriteLine("1 - stworz kontener na Plyny");
       Console.WriteLine("2 - stworz kontener na Gaz");
       Console.WriteLine("3 - stworz kontener na Produkty");
       Console.WriteLine("4 - cofnij");
       choose = Convert.ToInt32(Console.ReadLine());
       if (choose == 1)
       {
        CreateLiquidContainer();
       }else if (choose == 2)
       {
        CreateGasContainer();
       }else if (choose == 3)
       {
        CreateRefrigeratedContainer();
       }
       break;
      case 2:
       Console.WriteLine("Wybierz typ kontenera ktory chcesz zaladować");
       Console.WriteLine("1 - plyny");
       Console.WriteLine("2 - gazy");
       Console.WriteLine("3 - produkty");
       
       type = Convert.ToInt32(Console.ReadLine());
       if (type == 1)
       {
        liquidContainersList.ShowContainersList();
        Console.WriteLine("Wskaz numer kontenera który chcesz zaladować: ");
        index = Convert.ToInt32(Console.ReadLine());
        liquidContainersList.Load(index);
       }else if (choose == 2)
       {
        gasContainersList.ShowContainersList();
        Console.WriteLine("Wskaz numer kontenera który chcesz zaladować: ");
        index = Convert.ToInt32(Console.ReadLine());
        gasContainersList.Load(index);
       }else if (choose == 3)
       {
        productContainersList.ShowContainersList();
        Console.WriteLine("Wskaz numer kontenera który chcesz zaladować: ");
        index = Convert.ToInt32(Console.ReadLine());
        productContainersList.Load(index);
       }
       break;
      case 3:
       Console.WriteLine("Wybierz typ kontenera ktory chcesz rozladować");
       Console.WriteLine("1 - plyny");
       Console.WriteLine("2 - gazy");
       Console.WriteLine("3 - produkty");
       
       type = Convert.ToInt32(Console.ReadLine());
       if (type == 1)
       {
        liquidContainersList.ShowContainersList();
        Console.WriteLine("Wskaz numer kontenera który chcesz zaladować: ");
        index = Convert.ToInt32(Console.ReadLine());
        liquidContainersList.Unload(index);
       }else if (choose == 2)
       {
        gasContainersList.ShowContainersList();
        Console.WriteLine("Wskaz numer kontenera który chcesz zaladować: ");
        index = Convert.ToInt32(Console.ReadLine());
        gasContainersList.Unload(index);
       }else if (choose == 3)
       {
        productContainersList.ShowContainersList();
        Console.WriteLine("Wskaz numer kontenera który chcesz zaladować: ");
        index = Convert.ToInt32(Console.ReadLine());
        productContainersList.Unload(index);
       }
       break;
      case 4:
       showContainers();
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
  Console.WriteLine("3 - rozladuj kontener");
  Console.WriteLine("4 - lista kontenerów");
  Console.WriteLine("5 - cofnij");
 }

 private static void ExitMessage()
 {
  Console.WriteLine("Do widzenia!");
 }

 private static void CreateLiquidContainer()
 {
  Console.WriteLine("Czy kontener ma zawierac niebezpieczny ladunek?");
  int containeChoose = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Podaj maksymalna ladownosc kontenera");
  double maxWeight = Convert.ToDouble(Console.ReadLine());
  LiquidContainer container = new LiquidContainer(maxWeight, containeChoose == 1 ? true : false);
  liquidContainersList.AddContainer(container);
 }
 private static void CreateGasContainer()
 {
  Console.WriteLine("Podaj cisnienie kontenera");
  int pressure = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Podaj maksymalna ladownosc kontenera");
  double maxWeight = Convert.ToDouble(Console.ReadLine());
  GasContainer container = new GasContainer(maxWeight, pressure);
  gasContainersList.AddContainer(container);
 }
 private static void CreateRefrigeratedContainer()
 {
  Console.WriteLine("Podaj typ zawartosci kontenera");
  string productType = Convert.ToString(Console.ReadLine());
  Console.WriteLine("Podaj maksymalna ladownosc kontenera");
  double maxWeight = Convert.ToDouble(Console.ReadLine());
  RefrigeratedContainer container = new RefrigeratedContainer(maxWeight, productType);
  productContainersList.AddContainer(container);
 }

 private static void showContainers()
 {
  Console.WriteLine("Plyny");
  liquidContainersList.ShowContainersList();
  Console.WriteLine("Gazy");
  gasContainersList.ShowContainersList();
  Console.WriteLine("Produkty");
  productContainersList.ShowContainersList();
 }
}