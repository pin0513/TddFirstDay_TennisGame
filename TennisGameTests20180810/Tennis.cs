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
            if (IsDiffScore())
            {
                if (IsGamePoint())
                {
                    if (IsAdv())
                    {
                        return AdvPlayer() + " Adv";
                    }
                    if (IsWin())
                    {
                        return AdvPlayer() + " Win";
                    }
                }
                return NormalLookupState();
            }

            return SameScoreState();
        }

        private string AdvPlayer()
        {
            return (_firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName);
        }

        private bool IsWin()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) > 1;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private bool IsGamePoint()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private string NormalLookupState()
        {
            return _scoreLookUp[_firstPlayerScore] + " " + _scoreLookUp[_secondPlayerScore];
        }

        private string SameScoreState()
        {
            if (_firstPlayerScore >= 3)
            {
                return "Deuce";
            }

            return _scoreLookUp[_firstPlayerScore] + " All";
        }

        private bool IsDiffScore()
        {
            return _firstPlayerScore != _secondPlayerScore;
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