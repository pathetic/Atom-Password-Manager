using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Atom_Password_Manager
{
    class ManagerParole
    {
        public static Random rand = new Random();
        public static string MainPassword = "";
        public static string Extensie = ".atom";
        public static string NumeProgram = "ATOM";
        public static string LocatieFisier = "";
        public static int LungimeParola = Properties.Settings.Default.lungimeParola;
        public static int SecundeStergereParola = 5;

        public static void SalveazaParolele(string path, string pass)
        {
            string json = JsonConvert.SerializeObject(Cont.Conturi);
            File.WriteAllText(path, json);
            Encriptie.EncryptFile(path, pass);
        }

        public static bool CitesteConturi(string path, string parola)
        {
            //Convertim din json
            var bkCaracterePermise = CaracterePermise;
            CaracterePermise = "ABCDEFHIJKLMNOPQRSTUVWXYZ1234567890";

            string tempFilePath = System.IO.Path.GetTempPath() + $"atomtemp{RandomString(8)}.atom";
            CaracterePermise = bkCaracterePermise;
            File.Copy(path, tempFilePath);
            try
            {
                Encriptie.DecryptFile(tempFilePath, MainPassword);

                string convertMe = File.ReadAllText(tempFilePath);
                File.Delete(tempFilePath);
                Cont.Conturi = JsonConvert.DeserializeObject<List<Cont>>(convertMe);
            }
            catch {
                if (File.Exists(tempFilePath))
                    File.Delete(tempFilePath);
                return false;
            }
            return true;
        }
        public static void AdaugaExemple(int nr)
        {
            for (int i = 0; i < nr; i++)
            {
                Cont.Conturi.Add(new Cont($"email{i}", RandomString(LungimeParola), $"site{i}", "cont exemplu"));
            }
        }
        public static string CaracterePermise = Properties.Settings.Default.caractereParola;
        public static string RandomString(int length)
        {
            StringBuilder res = new StringBuilder();

            int randomInteger = rand.Next(0, CaracterePermise.Length);
            while (0 < length--)
            {
                res.Append(CaracterePermise[randomInteger]);
                randomInteger = rand.Next(0, CaracterePermise.Length);
            }
            return res.ToString();
        }
    }
}
