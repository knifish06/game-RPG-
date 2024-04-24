using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour 
{
    private int level;
    private int experience;
    private int expToNextLevel;

    public int playerLevel = 1;
    public int maxLevel = 10;
    public int currentExp = 0;
    public int expToLevelUp;

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
