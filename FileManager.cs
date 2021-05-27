using System;
using System.IO;

namespace TextFileManager
{
    public static class FileManager
    {
        public static string SeperateAllLines(string path, char separator)
        {
            if (!File.Exists(path)) { return "Missing file"; }
            
                StreamReader sr = File.OpenText(path);
                string s = "";
                string final = "";
                while((s = sr.ReadLine()) != null)
                {
                    final += $" {s}{separator}";
                }

                sr.Close();
                return final;
        }

        public static string ReadSpecificLine(string path, int line)
        {
            if (!File.Exists(path)) { return "Missing file"; }
            
            StreamReader sr = File.OpenText(path);
            string s = "";


            for (int i = 1; i <= line; i++)
            {
                s = sr.ReadLine();

                if (i == line && s != null)
                {
                    sr.Close();
                    return s;
                }

                if (i == line && s == null)
                {
                    return "Line doesn't exist or is empty";

                }

            }

            return "Line doesn't exist or is empty";
        }

        public static int LinesCount(string path)
        {
            if(!File.Exists(path)) { return 0; }
            
            StreamReader sr = File.OpenText(path);
            int final = 0;

            while((sr.ReadLine()) != null)
            {
                final++;
            }

            sr.Close();
            return final;

        }

        public static bool DoesExist(string path) => File.Exists(path);
        

        public static void WriteArrayToFile(string path, string[] array)
        {
            
            StreamWriter sw = new StreamWriter(path);

            if (!File.Exists(path)) { return; }
            
            foreach(string content in array)
            {
                sw.WriteLine(content);
            }
            sw.Close();
            
            
        }

        public static void WriteArrayToFile(string path, int[] array)
        {

            StreamWriter sw = new StreamWriter(path);

            if (!File.Exists(path)) { return; }

            foreach (int content in array)
            {
                sw.WriteLine(content);
            }
            sw.Close();
         

        }

        public static void WriteArrayToFile(string path, char[] array)
        {

            StreamWriter sw = new StreamWriter(path);

            if (!File.Exists(path)) { return; }

            foreach (char content in array)
            {
                sw.WriteLine(content);
            }
            sw.Close();
          

        }

        public static void WriteValueToFile(string path, object value)
        {
            StreamWriter sw = new StreamWriter(path);

            if (!File.Exists(path)) { return; }
          
            sw.WriteLine(value);
            sw.Close();
          
        }

        public static void CreateFile(string name)
        {
            StreamWriter sw = new StreamWriter($"{name}.txt");
            sw.Close();
        }

    }
}