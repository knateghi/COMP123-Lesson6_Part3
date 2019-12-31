using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_Part3
{
    class Card
    {
        //instance variables========================
        private string _face;
        private string _suit;
        //properties=========================

        public string Face { get => this._face; }
        public string Suit { get => this._suit; }

        //constructors===========================
        public Card(string face,string suit)
        {
            this._face = face;
            this._suit = suit;
        }
        //methods===========================
        public void Show()
        {
            Console.WriteLine($"{this._face} of {this._suit}");

        }
    }
}
