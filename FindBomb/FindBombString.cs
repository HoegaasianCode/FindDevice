using System;
using System.Collections.Generic;
using System.Text;

namespace FindBomb
{
    public class FindBombString
    {
        private readonly string _sentence;

        public FindBombString(string sentence)
        {
            _sentence = sentence;
        }

        public string Finder()
        {
            if (_sentence.ToLower().Contains("bomb")) return "Duck!!!";
            else return "Phew";
        }
    }
}
