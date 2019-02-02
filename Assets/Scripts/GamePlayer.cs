﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer {

    public GamePlayer(string name)
    {
        Name = name;
        Hand = new Hand();
        Points = 0;
        DrawPerTurn = 1;
        Colour = Random.ColorHSV();
        // set default win condition
        Q_PlayerPoints pointQuery = new Q_PlayerPoints();
        RunTimeValue playerPointQuery = new RunTimeValue(pointQuery, this);
        RunTimeValue winThreshold = new RunTimeValue(100);
        WinCondition = new Condition(playerPointQuery, winThreshold, ConditionOperator.AT_LEAST);
    }

    public string Name { get; set; }
    public Hand Hand { get; set; }
    public int Points { get; set; }
    public int DrawPerTurn { get; private set; }
    public Color Colour { get; set; }
    public Condition WinCondition { get; set; }

    public bool AddToHand (Card card)
    {
        return Hand.AddCard(card);
    }

    public void SetDrawPerTurn (int n) {
        if (n >= 1) {
            this.DrawPerTurn = n;
        }
    }
}
