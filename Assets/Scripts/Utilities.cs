using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    enum Timing
    {
        GameStart,
        CardIntoDeck,
        TurnBeginning,
        DrawPhase,
        DrawCard,
        CardIntoHand,
        ActionPhase,
        CardUsed,
        CostConsumed
    }

    struct Cost
    {
        Cost(int gold,int metal,int food)
        {
            this.gold = gold;
            this.metal = metal;
            this.food = food;
        }

        int gold;
        int metal;
        int food;

        public static Cost operator +(Cost a,Cost b)
        {
            return new Cost(a.gold + b.gold, a.metal + b.metal, a.food + b.food);
        }

        public static Cost operator -(Cost a, Cost b)
        {
            return new Cost(a.gold - b.gold, a.metal - b.metal, a.food - b.food);
        }
    }

    enum CardType
    {
        Creature,
        Structure,
        Magic,
        Warflag,
        Environment,
        Trap
    }
}
