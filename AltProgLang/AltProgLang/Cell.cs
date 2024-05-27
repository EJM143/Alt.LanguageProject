namespace AltProgLang;

public class Cell
{
    public String oem { set; get; }
    public String model { set; get; }
    public int launch_announced { set; get; }  // TODO
    public String launch_status { set; get; }
    public String body_dimensions{ set; get; }
    public float body_weight { set; get; } //TODO
    public String body_sim { set; get; }
    public String display_type { set; get; }
    public float display_size { set; get; } // Float
    public String display_resolution { set; get; }
    public String features_sensors { set; get; }
    
    public String platform_os { set; get; }

    public override string ToString()
    {
        return
            $"oem:{oem}, model:{model}, launch_announced: {launch_announced}, launch_status: {launch_status}, body_dimensions: {body_dimensions}, body_weight: {body_weight}, body_sim: {body_sim}, display_type: {display_type},display_size:{display_size}, display_resolution:{display_resolution}, features_sensors:{features_sensors}, platform_os:{platform_os}";
    }
}
