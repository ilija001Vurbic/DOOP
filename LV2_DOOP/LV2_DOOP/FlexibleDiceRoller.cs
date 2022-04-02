using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_DOOP
{
    class FlexibleDiceRoller : IModifiableDiceRoller, IFixedDiceRoller, ILoggable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public void RemoveDiceWithSides(int count)
        {
            for (int i = 0; i < dice.Count; i++)
            {
                if (dice[i].NumberOfSides == count)
                {
                    this.dice.RemoveAt(i);
                    this.resultForEachRoll.RemoveAt(i);
                    i--;
                }
            }
        }
        public string GetStringRepresentation()
        {
            return string.Join("\n", this.resultForEachRoll);
        }
    }
}
