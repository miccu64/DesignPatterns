using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.State
{
    public class CombinationLock
    {
        public static string StatusLocked = "LOCKED";
        public static string StatusOpen = "OPEN";
        public static string StatusError = "ERROR";

        public string Status { get; private set; }

        private readonly string _combination;

        public CombinationLock(IEnumerable<int> combination)
        {
            if (combination?.Any() != true)
                throw new ArgumentException("Incorrect combination.");

            _combination = string.Join("", combination);

            Status = StatusLocked;
        }

        public void EnterDigit(int digit)
        {
            if (digit < 0 || digit > 9)
                throw new ArgumentOutOfRangeException(nameof(digit));

            bool isCombinationInput = char.IsDigit(Status[0]);
            if (isCombinationInput)
            {
                Status += digit;

                bool lengthAchieved = Status.Length == _combination.Length;
                if (lengthAchieved)
                {
                    Status = Status == _combination
                        ? StatusOpen
                        : StatusError;
                }
            }
            else
            {
                Status = digit.ToString();
            }
        }
    }
}
