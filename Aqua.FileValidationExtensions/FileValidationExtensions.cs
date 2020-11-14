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

        /// <summary>
        /// Validate the file if a Hidden file
        /// </summary>
        /// <param name="fileFullPath"></param>
        /// <returns></returns>
        public static bool IsHidden(this string fileFullPath)
        {
            if (fileFullPath.IsValidFile())
            {
                var fileInfo = new FileInfo(fileFullPath);
                return (fileInfo.Attributes & FileAttributes.Hidden) != 0;
            }
            return false;
        }

        /// <summary>
        /// Validate the file if a Hidden file
        /// </summary>
        /// <param name="fileFullPath"></param>
        /// <returns></returns>
        public static bool IsHidden(this FileInfo fileFullPath) => (fileFullPath.Attributes & FileAttributes.Hidden) != 0;

        /// <summary>
        /// Validate the file if a Read Only file
        /// </summary>
        /// <param name="fileFullPath"></param>
        /// <returns></returns>
        public static bool IsReadOnly(this string fileFullPath)
        {
            if (fileFullPath.IsValidFile())
            {
                var fileInfo = new FileInfo(fileFullPath);
                return (fileInfo.Attributes & FileAttributes.ReadOnly) != 0;
            }
            return false;
        }

        /// <summary>
        /// Validate the file if a Read Only file
        /// </summary>
        /// <param name="fileFullPath"></param>
        /// <returns></returns>
        public static bool IsReadOnly(this FileInfo fileFullPath) => (fileFullPath.Attributes & FileAttributes.ReadOnly) != 0;

        /// <summary>
        /// Validate the file if an Operating System file
        /// </summary>
        /// <param name="fileFullPath"></param>
        /// <returns></returns>
        public static bool IsOperatingSystemFile(this string fileFullPath)
        {
            if (fileFullPath.IsValidFile())
            {
                var fileInfo = new FileInfo(fileFullPath);
                return (fileInfo.Attributes & FileAttributes.System) != 0;
            }
            return false;
        }

        /// <summary>
        /// Validate the file if an Operating System file
        /// </summary>
        /// <param name="fileFullPath"></param>
        /// <returns></returns>
        public static bool IsOperatingSystemFile(this FileInfo fileFullPath) => (fileFullPath.Attributes & FileAttributes.System) != 0;

        /// <summary>
        /// Validate the file if a Temporary file
        /// </summary>
        /// <param name="fileFullPath"></param>
        /// <returns></returns>
        public static bool IsTemporaryFile(this string fileFullPath)
        {
            if (fileFullPath.IsValidFile())
            {
                var fileInfo = new FileInfo(fileFullPath);
                return (fileInfo.Attributes & FileAttributes.Temporary) != 0;
            }
            return false;
        }

    }
}
