using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using LeagueOSx.DTO;
using LeagueOSx.WebService;
using Newtonsoft.Json;
using Gtk;


namespace LeagueOSx {
    class MainClass {
        public static void Main(string[] args) {
            //if(validateName("shiphtur")) {
            //    Console.WriteLine("true");
            //} else {
            //    Console.WriteLine("false");
            //}

            //Console.WriteLine(System.IO.Directory.GetCurrentDirectory());

            //Application.Init();
            //MainWindow win = new MainWindow();
            //win.Show();
            //Application.Run();

            //APIHandler api = new APIHandler();
            //string readText = File.ReadAllText("../SeedData/Masteries.json");
            string readText = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/../Configuration/app.config");

            //int result = api.GetChampionScoresAsync(19967304).Result;
            //Assets
            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory + "/../Assets");
            Console.WriteLine(readText);
        }


        public static bool validateName(string name) {
            return Regex.Matches(name, "^[0-9\\p{L} _\\.]+$").Count > 0;
        }
    }
}
