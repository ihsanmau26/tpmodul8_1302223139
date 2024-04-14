using System;
using System.Text.Json;

public class CovidConfig
{
    public string satuanSuhu { get; set; }

    public int batasHariDemam { get; set; }
    public string pesanDitolak { get; set; }

    public string pesanDiterima { get; set; }
    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("D:\\tpmodul8_1302223139\\tpmodul8_1302223139\\covid_config.json");
        CovidConfig config = JsonSerializer.Deserialize<CovidConfig>(jsonString);
        satuanSuhu = config.satuanSuhu;
        batasHariDemam = config.batasHariDemam;
        pesanDitolak = config.pesanDitolak;
        pesanDiterima = config.pesanDiterima;
    }
    public void UbahSatuan()
    {
        if (satuanSuhu == null)
        {
            satuanSuhu = "celcius";
        }
        else if (satuanSuhu == "celcius")
        {
            satuanSuhu = "fahrenheit";
        }
        else if (satuanSuhu == "fahrenheit")
        {
            satuanSuhu = "celcius";
        }
    }
}