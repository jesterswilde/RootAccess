using JetBrains.Annotations;
using Sirenix.Utilities.Editor;

public class PasswordFile : GameFile
{
    public string Password;
    public string HashedPassword;
    public bool isCracked = false;
    public int bruteForceResistance = 3;
    public int dictionaryResistance = 3;
    public bool isInRainbow = false;


}