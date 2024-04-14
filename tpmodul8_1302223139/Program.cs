public class Program
{
    public static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();
        config.ReadJSON();
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Berapa suhu badan anda saat ini? (Dalam nilai {0})", config.satuanSuhu);
            double inputSuhu = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
            int hariSakit = Convert.ToInt16(Console.ReadLine());

            if (config.satuanSuhu == "celcius")
            {
                if ((inputSuhu >= 36.5 && inputSuhu <= 37.5) && hariSakit <= config.batasHariDemam)
                {
                    Console.WriteLine(config.pesanDiterima);
                }
                else
                {
                    Console.WriteLine(config.pesanDitolak);
                }
            }
            else if (config.satuanSuhu == "fahrenheit")
            {
                if ((inputSuhu >= 97.7 && inputSuhu <= 99.5) && hariSakit <= config.batasHariDemam)
                {
                    Console.WriteLine(config.pesanDiterima);
                }
                else
                {
                    Console.WriteLine(config.pesanDitolak);

                }
            }
            Console.WriteLine();
            config.UbahSatuan();
        }
        Console.ReadLine();
    }
}