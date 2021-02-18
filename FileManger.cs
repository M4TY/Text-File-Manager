using System;
using System.IO;

namespace TextFileManager
{
    public static class FileManager
    {
        public static string SeperateAllLines(string path, char separator)
        {
            if (File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                string s = "";
                string final = "";
                while((s = sr.ReadLine()) != null)
                {
                    final += $"{s}{separator}";
                }

                sr.Close();
                return final;
            }
            return "Missing file";
            
        }

        public static string ReadSpecificLine(string path, int line)
        {
            if (File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                string s = "";
                

                for (int i = 1; i <= line; i++)
                {
                    s = sr.ReadLine();

                    if (i == line)
                    {
                        sr.Close();
                        return s;   
                    }

                    

                }
                return "Line doesn't exist";
            }
            return "Missing file";
        }

        public static int LinesCount(string path)
        {
            if(File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                string s = "";
                int final = 0;

                while((s = sr.ReadLine()) != null)
                {
                    final++;
                }

                sr.Close();
                return final;
            }

            return 0;
        }

        public static bool DoesExist(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }

        public static void WriteArrayToFile(string path, string[] array)
        {
            
            StreamWriter sw = new StreamWriter(path);

            if(File.Exists(path))
            {
                foreach(string content in array)
                {
                    sw.WriteLine(content);
                }
                sw.Close();
                

            }
            
        }

        public static void WriteValueToFile(string path, object value)
        {
            StreamWriter sw = new StreamWriter(path);

            if (File.Exists(path))
            {
                sw.WriteLine(value);
                sw.Close();
            }
        }
    }
}