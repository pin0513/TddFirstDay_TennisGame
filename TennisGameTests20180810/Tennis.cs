using System;
using System.Collections.Generic;

namespace TennisGameTests20180810
{
    public class Tennis
    {
        private int _firstPlayerScore;

        private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
            {
                { 0, "Love"},
                { 1, "Fifteen"},
                { 2, "Thirty"},
                { 3, "Forty"}
            };

        private int _secondPlayerScore;
        private string _firstPlayerName;
        private string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            if (_firstPlayerScore != _secondPlayerScore)
            {
                if (_firstPlayerScore >= 3 && _secondPlayerScore >= 3)
                {
                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1)
                    {
                        return (_firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName) + " Adv";
                    }
                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) > 1)
                    {
                        return (_firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName) + " Win";
                    }
                }

                if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
                {
                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) > 1)
                        return (_firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName) + " Win";
                }
                return _scoreLookUp[_firstPlayerScore] + " " + _scoreLookUp[_secondPlayerScore];
            }

            if (_firstPlayerScore >= 3)
            {
                return "Deuce";
            }
            return _scoreLookUp[_firstPlayerScore] + " All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}