using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolesAndScratches
{
    public class RandomNumberGenerator
    {
        private List<int> _numbers;

        public RandomNumberGenerator(int numbersToGenerate) =>
            _numbers = Enumerable.Range(1, numbersToGenerate).ToList();

        public bool HasNext() => _numbers.Count > 0;

        public int Get()
        {
            var randomIndex = new Random().Next(0, _numbers.Count);
            var randomNumber = _numbers[randomIndex];
            _numbers.RemoveAt(randomIndex);
            return randomNumber;
        }
    }
}
