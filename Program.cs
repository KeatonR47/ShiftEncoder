//Spencer & Keaton Lab 01 8/26/2025

using System.ComponentModel.Design.Serialization;
using System.Text.Encodings.Web;
bool running = true;
int ShiftVal = 1;

System.Console.WriteLine("automated testing ...");

System.Diagnostics.Debug.Assert(ShiftedCharacter('a') == 'b');

System.Diagnostics.Debug.Assert(ShiftedCharacter('z') == 'a');
System.Diagnostics.Debug.Assert(ShiftedCharacter('b', -1) == 'a');
System.Diagnostics.Debug.Assert(ShiftedCharacter('b', -2) == 'z');

System.Console.WriteLine("tests passed.");
Console.Clear();

while (running)
{
    ConsoleKeyInfo PressedKey = Console.ReadKey(true);
    if (PressedKey.Key == ConsoleKey.DownArrow)
    {
        ShiftVal--;
    }
    else if (PressedKey.Key == ConsoleKey.UpArrow)
    {
        ShiftVal++;
    }
    else if (PressedKey.Key == ConsoleKey.Escape)
    {
        running = false;
    }
    else if (PressedKey.Key == ConsoleKey.Spacebar)
    {
        Console.Write(' ');
    }
    else
    {
        Console.Write(ShiftedCharacter(PressedKey.KeyChar,ShiftVal));
    }
}



static char AsChar(int asciiValue)
{

    return (char)asciiValue;

}



static char ShiftedCharacter(char originalCharacter, int ShiftVal = 1)
{
    int index = originalCharacter - 'a' + ShiftVal;
    if ( index < 0 )
    {
        index += 26;
    }
    if ( index > 25)
    {
        index -=26;
    }
    return AsChar('a'+ index);
    
}



