//Spencer & Keaton Lab 01 8/26/2025



System.Console.WriteLine("automated testing ...");

System.Diagnostics.Debug.Assert(ShiftedCharacter('a') == 'b');

System.Diagnostics.Debug.Assert(ShiftedCharacter('z') == 'a');

System.Console.WriteLine("tests passed.");




char AsChar(int asciiValue) {

    return (char) asciiValue;

}



char ShiftedCharacter(char originalCharacter) {

    return AsChar((originalCharacter) == 'z' || originalCharacter == 'Z' ? (originalCharacter - 25) : (originalCharacter + 1));

}



Console.Write("Please Enter a character (I will display the shifted character): ");

Console.WriteLine(ShiftedCharacter(Console.ReadKey(true).KeyChar));