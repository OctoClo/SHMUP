﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameScore
{
    public static PhasingManager PhasingManager;

    static private uint multiplicator;
    static private uint score;

    static public uint Multiplicator
    {
        set
        {
            multiplicator = (value < 1) ? 1 : value;
        }
        get
        {
            return multiplicator;
        }
    }
    
    static public void AddToScore( uint pointAmount )
    {
        score += (pointAmount * multiplicator);
        PhasingManager.AddBoostKill();
    }

    static public uint Score
    {
        get
        {
            return score;
        }
    }

    public static void Reset()
    {
        multiplicator = 1;
        score = 0;
    }
}
