#pragma warning disable 0649
using System.Collections.Generic;

namespace ForumN
{
    public class PostBlockJSON {
        public string threadtitle;
        public string id;
        public int priority;
        public List<BlockConditionJSON> conditions = new List<BlockConditionJSON>();
        public List<PostJSON> posts = new List<PostJSON>();
        public bool ConditionsAreMet(int timestampe, Dictionary<string, int> rep, Dictionary<string, int> flags, Thread thread){
            foreach(var cond in conditions){
                if(cond.condition == "date")
                    if(!Compare(timestampe, cond.date, cond.op))
                        return false;
                if(cond.condition == "post_id")
                    if(cond.does_not_have && thread != null && thread.ContainedPostIDs.Contains(cond.post_id))
                        return false;
                    else if(!cond.does_not_have && (thread == null || !thread.ContainedPostIDs.Contains(cond.post_id)))
                        return false;
                if(cond.condition == "flag"){
                    var value = flags.GetOrDefault(cond.flag);
                    if(!Compare(value, cond.value, cond.op))
                        return false;
                }
                if(cond.condition == "rep"){
                    var value = rep.GetOrDefault(cond.username);
                    if(!Compare(value, cond.rep, cond.op))
                        return false;
                }
            }
            return true;
        }
        public bool Compare(int left, int right, string op){
            switch(op){
                case "==":
                    return left == right;
                case "!=":
                    return left != right;
                case ">":
                    return left > right;
                case "<":
                    return left < right;
                case ">=":
                    return left >= right;
                case "<=":
                    return left <= right;
            }
            return false;
        }
        public class PostJSON{
            public string content;
            public string username;
            public int timestamp;
        }
        public class BlockConditionJSON{
            public string condition;
            public string post_id;
            public bool does_not_have;
            public int date;
            public string flag;
            public string op;
            public int value;
            public string username;
            public int rep;
        }
    }
}