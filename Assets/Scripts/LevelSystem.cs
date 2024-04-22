using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem
{
    private int level;
    private int experience;
    private int expToNextLevel;

    public LevelSystem()
    {
        level = 0;
        experience = 0;
        expToNextLevel = 100;
    }

    public void AddExperience(int amount)
    {
        experience += amount;
        if (experience >= expToNextLevel)
        {
            level++;
            experience -= expToNextLevel;
        }
    }
}
