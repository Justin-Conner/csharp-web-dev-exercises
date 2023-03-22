// --------- Divide By Zero! ----------
 

   static double Divide(double x, double y)
   {
      if (y == 0.0)
      {
         throw new ArgumentOutOfRangeException("y", "You cannot divide by zero!");
      }
      else
      {
         return x / y;
      }
   }

// Test out your Divide() function here!
try
{
    double result = Divide(10, 0);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("An exception occurred: " + ex.Message);
    // handle the exception here
}



// --------- Test Student Labs ----------

static int CheckFileExtension(string fileName)
{
    if (fileName == null || fileName == "")
    {
        throw new ArgumentNullException("fileName", "Student did not submit any work!");
    }
    else
    {
        if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}

// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");

foreach (var student in students)
{
    try
    {
        int result = CheckFileExtension(student.Value);
        if (result == 0)
        {
            Console.WriteLine("Invalid file extension for student " + student.Key);
        }
        else
        {
            Console.WriteLine("Valid file extension for student " + student.Key);
        }
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine("An exception occurred for student " + student.Key + ": " + ex.Message);
        // handle the exception here
    }
}




