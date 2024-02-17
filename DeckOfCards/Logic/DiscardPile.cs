using CardDeckLogic.Scriptables;
using System.Collections.Generic;
using UnityEngine;

namespace CardDeckLogic
{
    public class DiscardPile : MonoBehaviour
    {
        private List<CardData> cardsInDiscard = new List<CardData>();
        public IReadOnlyList<CardData> CardsInDiscard => cardsInDiscard;

        public void AddToDiscard(CardData card)
        {
            cardsInDiscard.Add(card);
            Debug.Log($"Added {card.CardName} to the discard pile.");
        }

        public void ClearDiscardPile()
        {
            cardsInDiscard.Clear();
            Debug.Log("Discard pile cleared.");
        }
    }
}