using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class UnityExtensions
{
    public static bool Contains(this LayerMask mask, GameObject go)=> (1 << go.layer & mask) > 0;
    public static bool Contains(this LayerMask mask, Component comp)=> (1 << comp.gameObject.layer & mask) > 0;

     //Didn't write this one, it's from Unity Answers: https://forum.unity.com/threads/re-map-a-number-from-one-range-to-another.119437/
    public static float Map (this float value, float from1, float to1, float from2, float to2) {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
    
    /// <summary>
    /// Adds current list into another one.  This is mostly for LINQ chaining
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <param name="other"></param>
    /// <returns>Returns the list it was added into</returns>
    public static List<T> AddRangeInto<T>(this List<T> list, List<T> other)
    {
        other.AddRange(list);
        return other;
    }
    /// <summary>
    /// Destroys gameObjects of all direct children
    /// </summary>
    /// <param name="trans"></param>
    public static void DestroyChildren(this Transform trans)
    {
        foreach (Transform child in trans)
            GameObject.Destroy(child.gameObject);
    }
    public static List<GameObject> GetLineage(this Transform trans)
    {
        List<GameObject> gos = new List<GameObject>();
        Transform cur = trans;
        while(cur != null)
        {
            gos.Add(cur.gameObject);
            cur = cur.parent;
        }
        return gos;
    }
    /// <summary>
    /// Does this transform have any children, or has it decided that it prefers to be unteathered. 
    /// </summary>
    /// <param name="trans"></param>
    /// <returns></returns>
    public static bool HasChildren(this Transform trans) => trans.childCount > 0;
    /// <summary>
    /// Returns a list of transforms of direct children only (No grandchildren or further descendents.)
    /// </summary>
    /// <param name="parent"></param>
    /// <returns>List of child transforms</returns>
    public static List<Transform> GetDirectChildrenTransforms(this Component parent)
    {
        List<Transform> result = new List<Transform>();
        foreach (Transform child in parent.transform)
            result.Add(child);
        return result;
    }
    /// <summary>
    /// Returns a random element from a list. Returns default if list is empty.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <returns></returns>
    public static T PickRandom<T>(this List<T> list)
    {
        if (list.Count == 0)
            return default(T);
        return list[UnityEngine.Random.Range(0, list.Count)];
    }
    /// <summary>
    /// Shuffles a list into a new list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<T> Shuffle<T>(this List<T> list)
    {
        var result = list.ToList();
        for(int i = 0; i < list.Count; i++)
        {
            var randI = UnityEngine.Random.Range(0, result.Count);
            var temp = result[i];
            result[i] = result[randI];
            result[randI] = temp;
        }
        return result;
    }
    /// <summary>
    /// Shuffles an array in place. Returns itself.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <returns>The list that was given</returns>
    public static List<T> ShuffleInPlace<T>(this List<T> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            var randI = UnityEngine.Random.Range(0, list.Count);
            var temp = list[i];
            list[i] = list[randI];
            list[randI] = temp;
        }
        return list;
    }

    /// <summary>
    /// Gets an element from the list if the key exists. Otherwise returns default value.
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    /// <param name="dict"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static V GetOrDefault<K,V>(this Dictionary<K,V> dict, K key)
    {
        if (dict.ContainsKey(key))
            return dict[key];
        return default(V);
    }
    public static string TitleCase(this string input) {
        if (string.IsNullOrEmpty(input))
            return input;

        char[] charArray = input.ToLower().ToCharArray();
        bool capitalizeNext = true;

        for (int i = 0; i < charArray.Length; i++)
        {
            if (capitalizeNext && char.IsLetter(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
                capitalizeNext = false;
            }
            else if (charArray[i] == ' ')
            {
                capitalizeNext = true;
            }
        }
        return new string(charArray);
    }
    public static T MaxBy<T>(this IEnumerable<T> list, Func<T, float> selector)
    {
        if(list.Count() == 0)
            return default(T);
        T max = default(T);
        float maxVal = float.MinValue;
        foreach (var item in list)
        {
            var val = selector(item);
            if(val > maxVal)
            {
                maxVal = val;
                max = item;
            }
        }
        return max;
    }
    public static T MaxBy<T>(this IEnumerable<T> list, Func<T, T, float> selector)
    {
        if(list.Count() == 0)
            return default(T);
        T max = default(T);
        bool first = true;
        foreach (var item in list)
        {
            if(first)
            {
                max = item;
                first = false;
                continue;
            }
            if(selector(item, max) > 0)
                max = item;
        }
        return max;
    }

    //From https://stackoverflow.com/questions/49190830/is-it-possible-for-string-split-to-return-tuple
    public static void Deconstruct<T>(this IList<T> list, out T first, out IList<T> rest) {

        first = list.Count > 0 ? list[0] : default(T); // or throw
        rest = list.Skip(1).ToList();
    }

    public static void Deconstruct<T>(this IList<T> list, out T first, out T second, out IList<T> rest) {
        first = list.Count > 0 ? list[0] : default(T); // or throw
        second = list.Count > 1 ? list[1] : default(T); // or throw
        rest = list.Skip(2).ToList();
    }
    public static bool ToBool(this float val){
        return val > 0.5f;
    }

    public static string Base64Encode(this string plainText) {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    public static string Base64Decode(this string base64EncodedData) {
        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    }
}
