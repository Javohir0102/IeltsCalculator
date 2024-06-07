using System;

Console.Write("Enter the speaking score: ");
string inputSpeaking = Console.ReadLine();
double speaking = Convert.ToDouble(inputSpeaking);

Console.Write("Enter the listening score: ");
string inputListening = Console.ReadLine();
double listening = Convert.ToDouble(inputListening);

Console.Write("Enter the reading score: ");
string inputReading = Console.ReadLine();
double reading = Convert.ToDouble(inputReading);

Console.Write("Enter the writing score: ");
string inputWriting = Console.ReadLine();
double writing = Convert.ToDouble(inputWriting);



var grade = YourOverallScore(speaking, listening, reading, writing) switch 
{
    >= 4.5 and < 5.5 => "5-Modest",
    >= 5.5 and < 6.5 => "6-Component",
    >= 6.5 and < 7.5 => "7-Good",
    >= 7.5 and < 8.5 => "8-Very good",
    >= 8.5 and < 9 => "9-Expert",
    _ => "Below or above that range is Invalid"   
};
ShowPartialMessage(grade);

static double YourOverallScore(double speaking, double listening, double reading, double writing)
{
    double overall = (speaking+listening+reading+writing) / 4;
    return overall;
}

static void ShowPartialMessage(string message)
{
    Console.WriteLine(message);
}
