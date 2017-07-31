namespace Dojo_Time___Bowling
{
    public class Game
    {
        private int _score;
        private bool _strike;
        private bool _spare;
        private int previousRoll;
        private bool _firstRoll = true;

        public void Roll(int pins)
        {
            if (pins == 10)
            {
                _score += 0;

                if (!_strike)
                {
                    _strike = true;
                }

                _firstRoll = true;
                return;
            }
            
            _score += _strike ? 10 + pins * 2 : pins;

            if (_spare)
            {
                _score += pins;
                _spare = false;
            }

            if (pins + previousRoll == 10 && !_firstRoll)
            {
                _spare = true;
            }

            previousRoll = pins;
            _firstRoll = !_firstRoll;

            //_score += pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}