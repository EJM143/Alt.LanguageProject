using System.ComponentModel.Design;

namespace AltProgLang;
/// <summary>
/// A report generated from cellphone data.
/// </summary>
public class CellsReport
{
    HashSet<Cell> Cells = new HashSet<Cell>();
    private int duplicate = 0;
    
    /// <summary>
    /// Adds a cellphone record 
    /// </summary>
    /// <param name="c"> the cellphone record to add </param>
    public void AddCell(Cell c)
    {
        if (!Cells.Add(c))
        {
            duplicate++;
        }
        
    }
    /// <summary>
    /// Deletes a cellphone record
    /// </summary>
    /// <param name="c"> the cellphone record to delete </param>
    public void DeleteCell(Cell c)
    {
        Cells.Remove(c);
    }
    /// <summary>
    /// Retrieves the cound of duplicate cellphone records
    /// </summary>
    /// <returns> the count of duplicate records </returns>
    public int DuplicateRow()
    {
        return duplicate;
    }
    /// <summary>
    /// Method for generating a report showing the count of cellphone
    /// models announced each year.
    /// </summary>
    public void PrintYearlyModel()
    {
        Dictionary<int, int> yearlyList = new Dictionary<int, int>();
        
        foreach (var cell in Cells)
        {
            if (yearlyList.ContainsKey(cell.launch_announced))
            {
                yearlyList[cell.launch_announced]++;    
            }
            else
            {
                yearlyList.Add(cell.launch_announced, 1);
            }
        }

        foreach (var e in yearlyList)
        {
            Console.WriteLine($"{e.Key} : {e.Value}");
        }
    }
    /// <summary>
    /// Generates a report showing the count of cellphone
    /// models for each OEM.
    /// </summary>
    public void Printoem()
    {
        Dictionary<String, int> oemList = new Dictionary<String, int>();
        
        foreach (var cell in Cells)
        {
            if (oemList.ContainsKey(cell.oem))
            {
                oemList[cell.oem]++;    
            }
            else
            {
                oemList.Add(cell.oem, 1);
            }
        }

        foreach (var e in oemList)
        {
            Console.WriteLine($"{e.Key} : {e.Value}");
        }
    }
    /// <summary>
    /// Generates a report showing the count of cellphone
    /// models for each type of body sim
    /// </summary>
    public void PrintBodySim()
    {
        Dictionary<String, int> bodyList = new Dictionary<String, int>();

        foreach (var cell in Cells)
        {
            if (bodyList.ContainsKey(cell.body_sim))
            {
                bodyList[cell.body_sim]++;
            }
            else
            {
                bodyList.Add(cell.body_sim, 1);
            }
        }

        foreach (var e in bodyList)
        {
            Console.WriteLine($"{e.Key} : {e.Value}");
        }
    }
    /// <summary>
    /// Generates a report showing the count of cellphone
    /// for each type of display
    /// </summary>
    public void PrintDisplayType()
    {
        Dictionary<String, int> displayList = new Dictionary<String, int>();

        foreach (var cell in Cells)
        {
            if (displayList.ContainsKey(cell.display_type))
            {
                displayList[cell.display_type]++;
            }
            else
            {
                displayList.Add(cell.display_type, 1);
            }
        }

        foreach (var e in displayList)
        {
            Console.WriteLine($"{e.Key} : {e.Value}");
        }
    }
    /// <summary>
    /// Generates a report showing the count of cellphone
    /// models for each platform operating system
    /// </summary>
    public void PrintPlatformOs()
    {
        Dictionary<String, int> platformOsList = new Dictionary<String, int>();

        foreach (var cell in Cells)
        {
            if (platformOsList.ContainsKey(cell.platform_os))
            {
                platformOsList[cell.platform_os]++;
            }
            else
            {
                platformOsList.Add(cell.platform_os, 1);
            }
        }

        foreach (var e in platformOsList)
        {
            Console.WriteLine($"{e.Key} : {e.Value}");
        }
    }
    /// <summary>
    /// Prints the OEM with the highest average weight
    /// </summary>
    public void PrintHighestAveWt()
    {
        Dictionary<string, (float totalWt, int count)> oemWtData = new Dictionary<String, (float, int)>();

        foreach (var cell in Cells)
        {
            if (oemWtData.ContainsKey(cell.oem))
            {
                oemWtData[cell.oem] = (oemWtData[cell.oem].totalWt + cell.body_weight, oemWtData[cell.oem].count + 1);
            }
            else
            {
                oemWtData.Add(cell.oem, (cell.body_weight, 1));
            }
        }

        String highestOem = null;
        float highestAve = 0;

        foreach (var entry in oemWtData)
        {
            float aveWt = entry.Value.totalWt / entry.Value.count;
            if (aveWt > highestAve)
            {
                highestAve = aveWt;
                highestOem = entry.Key;
            }
        }

        Console.WriteLine($"The OEM with the highest average weight is {highestOem} with an average weight of {highestAve} grams.");
    }
    /// <summary>
    /// Generates a report showing cellphones that were
    /// announced in one year and released in another
    /// </summary>
    public void PrintPhonesInDiffYrs()
    {
        var phonesInDiffYrs = new List<Cell>();

        foreach (var cell in Cells)
        {
            int announcedYear = cell.launch_announced;
            int releasedYear = GetReleaseYr(cell.launch_status);

            if (announcedYear != 0 && releasedYear != 0 && announcedYear != releasedYear)
            {
                phonesInDiffYrs.Add(cell);
            }
        }

        if (phonesInDiffYrs.Count > 0)
        {
            Console.WriteLine("Phones announced in one year and released in another:");
            foreach (var cell in phonesInDiffYrs)
            {
                Console.WriteLine($"OEM: {cell.oem}, Model: {cell.model}, Announced: {cell.launch_announced}, Released: {GetReleaseYr(cell.launch_status)}");
            }
        }
        else
        {
            Console.WriteLine("There are no phones that were announced in one year and released in another.");
        }
    }
    /// <summary>
    ///  A helper method to extract the release year of cellphone 
    /// </summary>
    /// <param name="launchStatus"></param>
    /// <returns></returns>
    private int GetReleaseYr(string launchStatus)
    {
        if (string.IsNullOrEmpty(launchStatus))
        {
            return 0;
        }
        
        string[] words = launchStatus.Split(' ');
        foreach (string word in words)
        {
            if (int.TryParse(word, out int year) &&  year >= 2000 && year <= 2024)
            {
                return year;
            }
        }

        return 0;
    }
    /// <summary>
    /// Generates a report showing cellphones that have
    /// only one feature sensor.
    /// </summary>
    public void PrintPhonesWOneFSensor()
    {
    int count = 0;

    foreach (var cell in Cells)
    {
        if (!string.IsNullOrEmpty(cell.features_sensors))
        {
            string[] sensors = cell.features_sensors.Split(',');
            if (sensors.Length == 1)
            {
                count++;
            }
        }
    }

    Console.WriteLine($"The number of phones with only one feature sensor is {count}");
    }
    /// <summary>
    /// Generates a report showing the year with the highest
    /// number of cellphones launched after 1999
    /// </summary>
    public void PrintYrMostLaunched()
    {
        Dictionary<int, int> yearlyLaunchCount = new Dictionary<int, int>();

        foreach (var cell in Cells)
        {
            if (cell.launch_announced > 1999)
            {
                if (yearlyLaunchCount.ContainsKey(cell.launch_announced))
                {
                    yearlyLaunchCount[cell.launch_announced]++;
                }
                else
                {
                    yearlyLaunchCount.Add(cell.launch_announced, 1);
                }
            }
        }

        int yearMostPhones = 0;
        int maxCount = 0;

        foreach (var entry in yearlyLaunchCount)
        {
            if (entry.Value > maxCount)
            {
                maxCount = entry.Value;
                yearMostPhones = entry.Key;
            }
        }

        if (yearMostPhones > 0)
        {
            Console.WriteLine($"The year with the most phones launched after 1999 is {yearMostPhones} with {maxCount} phones.");
        }
        else
        {
            Console.WriteLine("There are no phones launched after 1999.");
        }
    }
    /// <summary>
    /// Overrides the ToString method to provide a string representation
    /// </summary>
    public void ToString()
    {
        foreach (var cell in Cells)
        {
            Console.WriteLine(
                $"{cell.oem}, {cell.model},  {cell.launch_announced}, {cell.launch_status}, {cell.body_dimensions},  {cell.body_weight},  {cell.body_sim},  {cell.display_type},{cell.display_size}, {cell.display_resolution}, {cell.features_sensors}, {cell.platform_os}");
        }
    }
    
    
}