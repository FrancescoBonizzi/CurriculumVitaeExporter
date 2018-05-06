using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculumVitaeExporter.Fluence
{
    public class FluentConsole
    {
        private ConsoleColor _defaultTextColor = ConsoleColor.Black;

        public FluentConsole Title(string title)
        {
            Console.Title = title;
            return this;
        }

        public FluentConsole TextColor(ConsoleColor color)
        {
            _defaultTextColor = color;
            Console.ForegroundColor = color;
            return this;
        }

        public FluentConsole BackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.Clear();
            return this;
        }

        public FluentConsole Encoding(Encoding encoding)
        {
            Console.OutputEncoding = encoding;
            return this;
        }

        public FluentConsole Size(int rowsNumber, int columnsNumber)
        {
            Console.SetWindowSize(rowsNumber, columnsNumber);
            return this;
        }

        public FluentConsole Tab()
        {
            Console.Write('\t');
            return this;
        }

        public FluentConsole NewLine()
        {
            Console.WriteLine();
            return this;
        }

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
