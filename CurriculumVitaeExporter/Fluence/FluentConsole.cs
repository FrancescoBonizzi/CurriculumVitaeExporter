using System;
using System.Text;

namespace CurriculumVitaeExporter.Fluence
{
    /// <summary>
    /// A wrapper to <see cref="Console"/> to have a fluent syntax
    /// </summary>
    public class FluentConsole
    {
        private ConsoleColor _defaultTextColor = ConsoleColor.Black;

        /// <summary>
        /// Sets a title to the Console
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public FluentConsole Title(string title)
        {
            Console.Title = title;
            return this;
        }

        /// <summary>
        /// Sets the foreground color to the Console
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public FluentConsole TextColor(ConsoleColor color)
        {
            _defaultTextColor = color;
            Console.ForegroundColor = color;
            return this;
        }

        /// <summary>
        /// Sets a background color to the console. Warning! It clears everything!
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public FluentConsole BackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.Clear();
            return this;
        }

        /// <summary>
        /// Sets the output encoding on the Console
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public FluentConsole Encoding(Encoding encoding)
        {
            Console.OutputEncoding = encoding;
            return this;
        }

        /// <summary>
        /// Sets the console windows size in number of rows and columns
        /// </summary>
        /// <param name="rowsNumber"></param>
        /// <param name="columnsNumber"></param>
        /// <returns></returns>
        public FluentConsole Size(int rowsNumber, int columnsNumber)
        {
            Console.SetWindowSize(rowsNumber, columnsNumber);
            return this;
        }

        /// <summary>
        /// Writes a tab on the Console
        /// </summary>
        /// <returns></returns>
        public FluentConsole Tab()
        {
            Console.Write('\t');
            return this;
        }

        /// <summary>
        /// Writes a new line on the Console
        /// </summary>
        /// <returns></returns>
        public FluentConsole NewLine()
        {
            Console.WriteLine();
            return this;
        }

        /// <summary>
        /// Writes a text on the Console. A custom color could be specified
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public FluentConsole Write(
            string text,
            ConsoleColor? color = null)
        {
            if (color != null)
                Console.ForegroundColor = color.Value;

            Console.Write(text);

            if (color != null)
                Console.ForegroundColor = _defaultTextColor;

            return this;
        }

        /// <summary>
        /// It draws an horizontal line of a fixed length on the Console
        /// </summary>
        /// <param name="numberOfColumns"></param>
        /// <returns></returns>
        public FluentConsole HorizontalLine(int numberOfColumns)
        {
            var line = new char[numberOfColumns];

            for (int c = 0; c < numberOfColumns; ++c)
                line[c] = '-';

            Console.Write(line);

            return this;
        }
    }
}
