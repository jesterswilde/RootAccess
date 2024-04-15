
using System.Collections.Generic;
public static class ValidFlags{
    static HashSet<string> flags = new HashSet<string>(){
		"lockpicking_level",
		"day",
		"time_segment"};
    public static bool IsValidFlag(string flag){
        return flags.Contains(flag);
    }
}
