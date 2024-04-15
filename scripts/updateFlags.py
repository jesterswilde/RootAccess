import os

flagsLocation = "../Assets/GameData/validFlags.txt"
outputLocation = "../Assets/Code/ValidFlags.cs"

validFlags = []
with open(flagsLocation, "r") as f:
    for line in f:
        validFlags.append("\"" + line.strip() +"\"")

dataToWrite = """
using System.Collections.Generic;
public static class ValidFlags{
    static HashSet<string> flags = new HashSet<string>(){
"""
dataToWrite += "\t\t"
dataToWrite += ",\n\t\t".join(validFlags)
dataToWrite += """};
    public static bool IsValidFlag(string flag){
        return flags.Contains(flag);
    }
}
"""

if not os.path.exists(outputLocation):
    os.makedirs(outputLocation)
if os.path.exists(outputLocation):
    os.remove(outputLocation)
with open(outputLocation, "w") as file:
    file.write(dataToWrite)