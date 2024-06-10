using System;
using System.ComponentModel.Design;
using System.Xml.XPath;

// Console.Write("Enter the speaking score: ");
// string inputSpeaking = Console.ReadLine();
// double speaking = Convert.ToDouble(inputSpeaking);

// Console.Write("Enter the listening score: ");
// string inputListening = Console.ReadLine();
// double listening = Convert.ToDouble(inputListening);

// Console.Write("Enter the reading score: ");
// string inputReading = Console.ReadLine();
// double reading = Convert.ToDouble(inputReading);

// Console.Write("Enter the writing score: ");
// string inputWriting = Console.ReadLine();
// double writing = Convert.ToDouble(inputWriting);

// Console.WriteLine(YourOverallScore(speaking, listening, reading, writing));

// var grade = YourOverallScore(speaking, listening, reading, writing) switch 
// {
//     >= 4.5 and < 5.5 => "5-Modest",
//     >= 5.5 and < 6.5 => "6-Component",
//     >= 6.5 and < 7.5 => "7-Good",
//     >= 7.5 and < 8.5 => "8-Very good",
//     >= 8.5 and < 9 => "9-Expert",
//     _ => "Below or above that range is Invalid"   
// };
// ShowPartialMessage(grade);

// static double YourOverallScore(double speaking, double listening, double reading, double writing)
// {
//     double overall = (speaking+listening+reading+writing) / 4;
//     return overall;
// }

// static void ShowPartialMessage(string message)
// {
//     Console.WriteLine(message);
// }

Console.WriteLine("Welcome to Ielts calculator program");
char select = '1';
do
{    
    PrintText("Enter the speaking score: ");
    decimal speaking = ParseToDecimal();

    PrintText("Enter the listening score: ");
    decimal listening = ParseToDecimal();

    PrintText("Enter the reading score: ");
    decimal reading = ParseToDecimal();

    PrintText("Enter the writing score: ");
    decimal writing = ParseToDecimal();

    decimal overall = (speaking+listening+reading+writing) / 4;
    decimal residue = overall % (int)overall;
    decimal avaregeScore = overall - residue + ExtractReminder(residue);
    string yourlevel = LevelName(avaregeScore);

    Console.ForegroundColor = ConsoleColor.Green;
    PrintParagraph($"Your overall: {avaregeScore:f1}\nyour category: {yourlevel}");
    Console.ForegroundColor = ConsoleColor.White;

    string LevelName(decimal avaregeScore)
    {
        return avaregeScore switch
        {
            5 => "Modest",
            5.5m or 6 => "Competent",
            6.5m or 7 => "Good",
            7.5m or 8 => "Very Good",
            8.5m or 9 => "Expert",
            _ => "Your lever is not included to here"
        };
    }

    decimal ExtractReminder(decimal avaregeScore)
    {
        var result = residue switch
        {
            < 0.25m => 0,
            < 0.75m => 0.5m,
            _ => 1
        };
        return result;
    }

    void PrintParagraph(string message)
    {
        Console.WriteLine(message);
    }
    void PrintText(string message)
    {
        Console.Write(message);
    }

    decimal ParseToDecimal()
    {
        string input = Console.ReadLine();
        try
        {
            decimal parsedValue = Convert.ToDecimal(input);
            return parsedValue;        
        }
        catch (FormatException)
        {    
            throw new ("Qoymatning formati xato kiritildi");
        }
        catch (OverflowException)
        {
            throw new ("Juda katta qiymat berilgan!");
        }
        catch (Exception)
        {
            throw new Exception("Qiymat xato kiritilgan!");
        }
    }
    PrintText("Continuing to click '1' closing click any button: ");
    select = Convert.ToChar(Console.ReadLine());

} while (select == 1);

