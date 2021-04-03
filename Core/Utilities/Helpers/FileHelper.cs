using Microsoft.AspNetCore.Http;
using System;
using System.IO;


namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile formFile)
        {
            var sourcePath = Path.GetTempFileName();
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            var path = NewPath(formFile);
            File.Move(sourcePath, path);
            return path;
        }

        public static void Delete(string path)
        {
            File.Delete(path);
        }

        public static string Update(string sourcePath, IFormFile formfile)
        {
            var path = NewPath(formfile);
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    formfile.CopyTo(stream);
                }
            }
            File.Delete(sourcePath);
            return path;
        }

        private static string NewPath(IFormFile formFile)
        {
            FileInfo fileInfo = new FileInfo(formFile.FileName);
            string fileExtension = fileInfo.Extension;
            var newPath = Guid.NewGuid().ToString() + fileExtension;
            string result = $@"wwwroot\Images\{newPath}";
            return result;
        }
    }
}
