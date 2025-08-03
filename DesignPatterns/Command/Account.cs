using DesignPatterns.Command.Models;
using System;

namespace DesignPatterns.Command
{
    public class Account
    {
        public int Balance { get; set; }

        public void Process(CommandInfo command)
        {
            switch (command.Action)
            {
                case ActionType.Deposit:
                    Deposit(command);
                    break;
                case ActionType.Withdraw:
                    Withdraw(command);
                    break;
                default:
                    throw new Exception("Unsupported action type");
            }
        }

        private void Deposit(CommandInfo command)
        {
            Balance += command.Amount;
            command.Success = true;
        }

        private void Withdraw(CommandInfo command)
        {
            if (Balance >= command.Amount)
            {
                Balance -= command.Amount;
                command.Success = true;
            }
            else
            {
                command.Success = false;
            }
        }
    }
}
