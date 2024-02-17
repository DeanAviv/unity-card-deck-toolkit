using System.Collections.Generic;
using UnityEngine;

namespace CardDeckLogic.Scriptables
{
    [CreateAssetMenu(fileName = "NewDeck", menuName = "ScriptableObjects/DeckData", order = 1)]
    public class DeckData : ScriptableObject
    {
        [SerializeField] private string deckName;
        [SerializeField] private string description;
        [SerializeField] private Sprite coverArtwork;
        [SerializeField] private List<CardData> cards;

        public string DeckName { get => deckName; }
        public string Description { get => description; }
        public Sprite CoverArtwork { get => coverArtwork; }
        public IReadOnlyList<CardData> Cards { get => cards; }

        public override string ToString()
        {
            string deckInfo = $"Deck Name: {deckName}\nDescription: {description}\nCard Count: {cards.Count}\n";
            string cardsInfo = "";
            foreach (CardData card in cards)
            {
                cardsInfo += card.ToString() + "\n";
            }
            return deckInfo + cardsInfo;
        }
    }
}