using System;

namespace ResharperEssentials.Testing
{
    public class SimpleCalculator
    {
        private int _currentValue;

        public SimpleCalculator()
        {
        }

        public SimpleCalculator(int value)
        {
            _currentValue = value;
        }

        public int Value => _currentValue;

        public void Add(int value)
        {
            _currentValue = _currentValue + value;
        }

        public void Subtract(int value)
        {
            throw new NotImplementedException();
        }
    }
}