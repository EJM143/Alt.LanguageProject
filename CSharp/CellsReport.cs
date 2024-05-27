namespace CSharp;

public class CellsReport
{
    HashSet<Cell> Cells = new HashSet<Cell>();
    private int duplicate = 0;
    
    public void AddCell(Cell c)
    {
        if (!Cells.Add(c))
        {
            duplicate++;
        }
        
    }
    
    public void DeleteCell(Cell c)
    {
        Cells.Remove(c);
    }
    public int DuplicateRow()
    {
        return duplicate;
    }

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

    public void ToString()
    {
        foreach (var cell in Cells)
        {
            Console.WriteLine(
                $"{cell.oem}, {cell.model},  {cell.launch_announced}, {cell.launch_status}, {cell.body_dimensions},  {cell.body_weight},  {cell.body_sim},  {cell.display_type},{cell.display_size}, {cell.display_resolution}, {cell.features_sensors}, {cell.platform_os}");
        }
    }
}