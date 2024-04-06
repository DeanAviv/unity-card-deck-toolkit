# Unity Card Deck Toolkit

A toolkit designed for Unity developers to create and manage card decks, demonstrating the power of scriptable objects. Developed as a personal learning project.

## Features

- Create and manage card decks in Unity projects.
- Demonstrates the usage of scriptable objects for data management.
- Includes functionality for shuffling decks, drawing cards, and adding cards to decks.

## Usage

1. **Setup**:
   - Import the `CardDeckLogic` namespace in your scripts to access the card deck functionality.
   - Create `DeckData` scriptable objects to define your card decks.
   - Create `CardData` scriptable objects to define individual cards.

2. **Create Decks**:
   - Define your card decks by creating instances of `DeckData` scriptable objects.
   - Customize the deck name, description, cover artwork, and list of cards.

3. **Manage Decks**:
   - Use the `CardDeck` class to manage your card decks within your Unity project.
   - Shuffle decks, draw cards, add cards to decks, and manage a discard pile.

## Scripts Overview

- **CardDeck.cs**: Defines the `CardDeck` class for managing card decks. Includes functionality for shuffling decks, drawing cards, and adding cards.
- **DeckData.cs**: Defines the `DeckData` scriptable object class for defining card decks. Includes properties for deck name, description, cover artwork, and list of cards.
- **CardData.cs**: Defines the `CardData` scriptable object class for defining individual cards. Includes properties for card name, description, artwork, mana cost, power, defense, and health.
- **DiscardPile.cs**: Defines the `DiscardPile` class for managing a discard pile in Unity card games. Provides methods to add cards to the discard pile and clear the discard pile.

## Installation

1. Clone or download this repository.
2. Copy the `DeckOfCards` folder into your Unity project's `Assets` directory.
3. Use the provided classes and scriptable objects in your Unity project as needed.

## Example

```csharp
using UnityEngine;
using CardDeckLogic.Scriptables;
using CardDeckLogic;

public class ExampleUsage : MonoBehaviour
{
    public DeckData exampleDeck;

    private CardDeck cardDeck;

    private void Start()
    {
        cardDeck = GetComponent<CardDeck>();
        if (cardDeck != null && exampleDeck != null)
        {
            // Shuffle the example deck
            cardDeck.Data = exampleDeck;
            cardDeck.ShuffleDeck();
        }
    }
}
```

## License

This project is licensed under the [MIT License](LICENSE).
