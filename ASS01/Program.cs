using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASS01
{
    internal class Program
    {
        static void Main(string[] args)
        #region Q1
        {
            //Console.WriteLine("Days of the Week:");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //} 
            #endregion

            #region Q2
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();
            //Season season;

            //if (Enum.TryParse(input, true, out season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}

            #endregion

            #region Q3
            //Permissions userPermissions = Permissions.Read | Permissions.Write;

            //Console.WriteLine("Current Permissions: " + userPermissions);

            //// Add Permission
            //userPermissions |= Permissions.Delete;
            //Console.WriteLine("After Adding Delete: " + userPermissions);

            //// Remove Permission
            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine("After Removing Write: " + userPermissions);

            //// Check Permission
            //if (userPermissions.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("User has Read Permission.");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have Read Permission.");
            //}

            #endregion

            #region Q4
            //Console.WriteLine("Enter a color name: ");
            //string input = Console.ReadLine();
            //Colors color;

            //if (Enum.TryParse(input, true, out color))
            //{
            //    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            //    {
            //        Console.WriteLine($"{color} is a primary color.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{color} is not a primary color.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color entered.");
            //}

            #endregion













        }
    }
}
