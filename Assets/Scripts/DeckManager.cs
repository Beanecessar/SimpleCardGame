using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DeckManager
{
    List<Card> cardList;


    public void InitailizeCardList(Deck deck)
    {
        //Change to random order.
        foreach(KeyValuePair<Card, uint> pair in deck.Cards)
        {
            for(uint i = 0; i < pair.Value; ++i)
            {
                cardList.Add(pair.Key);
            }
        }
    }

    public void InsertCard(Card card)
    {
        //Change to random insert.
        cardList.Add(card);
    }
}
