using System;
using System.IO;

namespace WorkingWithStrings
{
    class EmailFinder
    {
        /// <summary>
        /// Ищет в sourcePath адреса E-mail и записывает их в destPath
        /// </summary>
        /// <param name="sourcePath">Исходный текстовый файл</param>
        /// <param name="destPath">Результирующий текстовый файл</param>
        public void Find(string sourcePath, string destPath)
        {
            try
            {
                if (File.Exists(destPath)) File.Delete(destPath);

                using StreamReader reader = new(sourcePath);

                while (!reader.EndOfStream)
                {
                    string str = reader.ReadLine();
                    SearchMail(ref str);
                    WriteFile(str, destPath);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void SearchMail(ref string str)
        {
            str = str[(str.IndexOf('&') + 1)..].Trim();
        }

        private void WriteFile(string str, string path)
        {
            try
            {
                using StreamWriter writer = new(path, true);

                writer.WriteLine(str);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
