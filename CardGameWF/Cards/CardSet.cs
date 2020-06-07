﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameWF
{

    class CardSet
    {
        public List<Card> Cards { get; set; }

        protected int Count
        {
            get { return Cards.Count; }
        }

        public CardSet(List<Card> cards)
        {
            this.Cards = cards;
        }

        public CardSet() : this(new List<Card>())
        { }

        public CardSet(int count) : this()
        {
            FullDeck(count);
        }

        private void FullDeck(int count)
        {
            foreach (var figure in Enum.GetValues(typeof(CardFigure)))
            {
                foreach (var suit in Enum.GetValues(typeof(CardSuit)))
                {
                    Cards.Add(GetCard((CardFigure)figure, (CardSuit)suit));
                }
            }
            if (count < Count)
                Cards.RemoveRange(0, Count - count);
        }

        public virtual Card GetCard(CardFigure figure, CardSuit suit)
        {
            return new Card(figure, suit);
        }

        public void Mix()
        {
            Random rnd = new Random();
            List<Card> newCards = new List<Card>();

            for (int i = Cards.Count; i > 0; i--)
            {
                Card a = Cards[rnd.Next(0, Cards.Count)];
                newCards.Add(a);
                Cards.Remove(a);
            }

            Cards = newCards;
        }

        public Card Pull()
        {
            return Pull(0);
        }

        public Card Pull(int number)
        {
            if (number > Count - 1) return null;

            Card a = Cards[number];
            Cards.RemoveAt(number);
            return a;
        }

        public Card Pull(Card card)
        {
            int ind = Cards.IndexOf(card);
            if (ind == -1) throw new Exception("Card's not find from cardset");
            return Pull(ind);
        }

        public virtual void Show()
        {
            foreach (var item in Cards)
            {
                item.Show();
            }

        }

        public virtual void Sort()
        {
            Cards.Sort((card1, card2) =>
            card1.Figure.CompareTo(card2.Figure) == 0 ?
            card1.Suit.CompareTo(card2.Suit) :
            card1.Figure.CompareTo(card2.Figure)
                );
        }

        public CardSet Deal(int amount)
        {
            CardSet c = new CardSet();
            if (amount > Cards.Count) amount = Cards.Count;

            for (int i = 0; i < amount; i++)
            {
                c.Add(Cards[0]);
                Cards.RemoveAt(0);
            }

            return c;
        }

        public void Add(params Card[] card)
        {
            foreach (var item in card)
            {
                Cards.Add(item);
            }
        }

        public void Add(CardSet cards)
        {
            Add(cards.Cards.ToArray());
        }
    }
}
