using System.IO;

namespace Aqua.FileValidationExtensions
{
    public static class FileValidationExtensions
    {
        /// <summary>
        /// Validate the input string is not Empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsNullOrEmptyOrWhiteSpace(this string input) => string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input);

        /// <summary>
        /// Validate the file is exists
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsValidFile(this string fileFullPath) => fileFullPath.IsNullOrEmptyOrWhiteSpace() && File.Exists(fileFullPath);




    }
}
