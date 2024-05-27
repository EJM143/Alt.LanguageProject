namespace AltProgLang;

class DataProcessing
{
    static void Main(string[] args)
    {
        readFile("../../../Data/cells.csv");
    }

    static void  readFile(String fileLoc)
    {
        CellsReport cellsReport = new CellsReport();
        
        using (StreamReader read = new StreamReader(fileLoc)) {
            string line;
            line = read.ReadLine();
            while ((line = read.ReadLine()) != null) {
               // Console.WriteLine(line);
                //CellPhoneRecord record = 
                 Cell c =   ParseLine(line);
                 cellsReport.AddCell(c);
                
            }
            
        }
        Console.WriteLine();
        Console.WriteLine("*** Yearly Model Count *** ");
        cellsReport.PrintYearlyModel();
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("*** OEM Count *** ");
        cellsReport.Printoem();
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("*** Body Sim Count *** ");
        cellsReport.PrintBodySim();
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("*** Display Type Count *** ");
        cellsReport.PrintDisplayType();
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("*** Platform OS Count *** ");
        cellsReport.PrintPlatformOs();
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Duplicate Report: " + cellsReport.DuplicateRow());
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------------");
        // cellsReport.ToString();

    }

    public static Cell ParseLine(string line)
    {
        string[] subs = line.Split(',');
        Cell c = new Cell();
        
        int index = 0;
        for (int i = 0; i < 12 && index < subs.Length; i++)
        {
            String str = subs[index];
            index++;
            if (!String.IsNullOrEmpty(str) && str[0] == '\"')
            {
                while (index < subs.Length)
                {
                    str += ',';
                    str += subs[index];
                    index++;
                    if (str[^1] == '\"')
                    {
                        break;
                    }
                }

                str = str.Substring(1, str.Length - 2);
            }
            
            // Console.WriteLine($"Substring: {str}");
            switch (i)
            {
                case 0:
                    c.oem = str;
                    break;
                case 1:
                    c.model = str;
                    break;
                case 2 :
                    c.launch_announced = GetLaunchYear(str);
                    break;
                case 3 :
                    c.launch_status = str;
                    break;
                case 4:
                    c.body_dimensions =  str;
                    break;
                case 5:
                    c.body_weight = GetBodyWeight(str);
                    break;
                case 6:
                    c.body_sim = str;
                    break;
                case 7:
                    c.display_type = str;
                    break;
                case 8:
                    c.display_size = GetDisplaySize(str);
                    break;
                case 9 :
                    c.display_resolution = str;
                    break;
                case 10:
                    c.features_sensors = str;
                    break;
                case 11:
                    c.platform_os = str;
                    break;
            }
            
            
        }

        return c;
    }

    private static int GetLaunchYear(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return 0;
        }

        string year = "";
        for (int i = 0; i < 4; i++)
        {
            if (Char.IsDigit(str[i]))
            {
                year += str[i];
            }
            else
            {
                return 0;
            }
        }

        return Int32.Parse(year);
    }

    private static float GetDisplaySize(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return 0;
        }

        String size = "";
        bool flag = false;
        foreach (char c in str)
        {
            if (Char.IsDigit(c) || c == '.')
            {
                size += c;
            }
            else if(Char.IsWhiteSpace(c))
            {
                continue;
            }else if (c == 'i')
            {
                flag = true;
                break;
            }
        }

        if (flag)
        {
            return float.Parse(size);
        }
        else
        {
            return 0;
        }
    }

    private static float GetBodyWeight(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return 0;
        }

        String weight = "";
        bool flag = false;
        foreach (char c in str)
        {
            if (Char.IsDigit(c))
            {
                weight += c;
            }
            else if(Char.IsWhiteSpace(c))
            {
                continue;
            }else if (c == 'g')
            {
                flag = true;
                break;
            }
        }

        if (flag)
        {
            return Int32.Parse(weight);
        }
        else
        {
            return 0;
        }
    }
}