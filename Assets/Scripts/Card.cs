using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

abstract class Card
{
    string name;
    string Name
    {
        get { return name; }
    }

    uint id;
    uint Id
    {
        get { return id; }
        set { id = value; }
    }

    CardType type;
    CardType Type
    {
        get { return type; }
    }

    Cost cost;
    Cost Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    uint maxNum;
    uint MaxNum
    {
        get { return maxNum; }
    }
}
