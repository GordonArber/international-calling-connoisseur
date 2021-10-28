using System.Collections.Generic;
using System.Linq;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>() { {1,"United States of America"}, {55, "Brazil"}, {91, "India"} };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int CountryCode, string CountryName)
    {
        return new Dictionary<int, string> { { CountryCode, CountryName } };
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string CountryName)
    {
        existingDictionary.Add(countryCode, CountryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        return !existingDictionary.ContainsKey(countryCode) ? string.Empty : existingDictionary[countryCode];
    }
    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (!CheckCodeExists(existingDictionary,countryCode)) return existingDictionary;

        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }
    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        var longestCountryName = "";
        foreach (var country in existingDictionary.Where(country => country.Value.Length > longestCountryName.Length))
        {
            longestCountryName = country.Value;
        }

        return longestCountryName;
    }
}
