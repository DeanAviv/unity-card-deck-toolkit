using UnityEngine;
using CardDeckLogic.Scriptables;
using System.Collections.Generic;
using System.Linq;

namespace CardDeckLogic
{
    public class CardDeck : MonoBehaviour
    {
        private List<CardData> liveDeck;
        [SerializeField] private DeckData data;
        public DeckData Data 
        { 
            get => data; 
            private set
            {
                data = value;
            }
        }

        private int cardsInDeck;
        public int CardsInDeck
        {
            get => cardsInDeck;
            private set 
            {
                cardsInDeck = value;
            }
        }

        public bool IsFull { get => liveDeck.Count == data.Cards.Count; }
        public bool ContainsCard(CardData card) => data.Cards.Contains(card);


        public void ShuffleDeck()
        {
            liveDeck = new List<CardData>(data.Cards);
            Shuffle();
        }

        /// <summary>
        /// Shuffles the deck of cards using the Fisher-Yates shuffle algorithm
        /// </summary>
        private void Shuffle()
        {
            int count = liveDeck.Count;
            while(count > 1)
            {
                count--;
                int randomIndex = Random.Range(0, count + 1); 
                var value = liveDeck[randomIndex]; 
                liveDeck[randomIndex] = liveDeck[count]; 
                liveDeck[count] = value;
            }
        }

        public List<CardData> DrawCards(int amount) 
        {
            if (amount <= 0)
            {
                Debug.LogWarning("Failed to pull cards from the deck: Invalid amount specified.");
                return null;
            }
            return PulledCards(amount);
        }

        /// <summary>
        /// Returns a list of the pulled cards from the deck, 
        /// If there are not enough cards to pull in deck will pull the amount of cards availalbe in deck
        /// Using the Mathf.Min method 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private List<CardData> PulledCards(int amount)
        {
            List<CardData> cards = new List<CardData>();
            int cardsToPull = Mathf.Min(amount, liveDeck.Count);
            for (int i = 0; i < cardsToPull; i++)
            {
                cards.Add(liveDeck[i]);
            }

            liveDeck.RemoveRange(0, cardsToPull);
            return cards;
        }

        public void AddCard(CardData card)
        {
            if (IsFull)
            {
                Debug.LogWarning("Failed to add cards to deck: Deck is full.");
                return;
            }

            liveDeck.Add(card);
        }
    }
}
