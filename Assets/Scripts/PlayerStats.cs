using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public int playerLevel = 1;
    public int maxLevel = 30;
    public Text levelText;
    public int currentExp;
    public int baseExp = 100 ;
    public int[] expToLevelUp;

    // Start is called before the first frame update
    void Start()
    { 
        levelText.text = "Level: " + playerLevel;
        expToLevelUp = new int[maxLevel];
        expToLevelUp[1] = baseExp;
        for(int i = 0; i < expToLevelUp.Length; i++)
        {
            expToLevelUp[i] = Mathf.FloorToInt(expToLevelUp[i -1] * 1.05f) ;
        }    

    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
