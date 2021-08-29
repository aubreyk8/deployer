using System;
using System.IO;
using Newtonsoft.Json;

public class Configurations
{
    private const string ConfigFile = "deployer.json";
    public string type { get; set; }
    public bool Optimize { get; set; }
    public bool Horizon { get; set; }
    public bool Migrate { get; set; }
    private string configObject { get; set; }
    
    public Configurations()
    {
        if (File.Exists(ConfigFile))
        {
            StreamReader r = new StreamReader(ConfigFile);
            this.configObject = r.ReadToEnd();
            r.Close();


            
        }
    }
    
    public Configurations GetConfigurations()
    {
        return JsonConvert.DeserializeObject<Configurations>(this.configObject);
    }
}