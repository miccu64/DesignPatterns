﻿using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Facade.Models
{
    public class Verifier
    {
        public bool Verify(List<List<int>> array)
        {
            if (!array.Any()) return false;

            var expected = array.First().Sum();

            return array.All(t => t.Sum() == expected);
        }
    }
}
