using UnityEngine;

namespace CardDeckLogic.Scriptables
{
    [CreateAssetMenu(fileName = "NewCard", menuName = "ScriptableObjects/CardData", order = 1)]
    public class CardData : ScriptableObject
    {
        [SerializeField] private string cardName;
        [SerializeField] private string description;
        [SerializeField] private Sprite artwork;
        [SerializeField] private int manaCost;
        [SerializeField] private int power;
        [SerializeField] private int defense;
        [SerializeField] private int health;

        public string CardName { get => cardName; }
        public string Description { get => description; }
        public Sprite Artwork { get => artwork; }
        public int ManaCost { get => manaCost; }
        public int Power { get => power; }
        public int Defense { get => defense; }
        public int Health { get => health; }

        public override string ToString()
        {
            return $"{cardName} - Mana Cost: {manaCost}, Power: {power}, Defense: {defense}, Health: {health}";
        }
    }
}