﻿using Core.Results.Abstract;
using Core.Results.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var result = newPath(file);

            var sourcepath = Path.GetTempFileName();

            using (var stream = new FileStream(sourcepath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Move(sourcepath, result.newPath);

            return result.Path2;
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            using (var stream = new FileStream(result.newPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Delete(sourcePath);

            return result.Path2;
        }

        public static IResult Delete(string path)
        {
            File.Delete(path);
            return new SuccessResult("Deleted");
        }

        public static (string newPath, string Path2) newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;
            var newFilename = Guid.NewGuid().ToString("N") + fileExtension;
            string path12 = @"\wwwroot\Images\";
            string result = Environment.CurrentDirectory + path12 + newFilename;
            return (result, $"\\Images\\{newFilename}");
        }
    }
}
