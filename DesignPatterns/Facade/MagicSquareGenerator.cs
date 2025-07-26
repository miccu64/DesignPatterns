using DesignPatterns.Facade.Models;
using System.Collections.Generic;

namespace DesignPatterns.Facade
{
    public class MagicSquareGenerator
    {
        private readonly Generator generator = new Generator();
        private readonly Splitter splitter = new Splitter();
        private readonly Verifier verifier = new Verifier();

        public List<List<int>> Generate(int size)
        {
            List<List<int>> square = new List<List<int>>();

            bool isMagicSquare;
            do
            {
                square.Clear();

                for (int i = 0; i < size; ++i)
                    square.Add(generator.Generate(size));

                var splittedSquare = splitter.Split(square);

                isMagicSquare = verifier.Verify(splittedSquare);
            }
            while (!isMagicSquare);

            return square;
        }
    }
}
