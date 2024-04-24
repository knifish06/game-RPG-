using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemLevel : MonoBehaviour
{

    private int level;
    private Skeleton skeExp;
    public Text levelText;
    public Text expText;

    public int playerLevel = 1;
    public int maxLevel = 10;
    public int currentExp = 0;
    public int expToLevelUp;
    // Start is called before the first frame update
    void Start()
    {
       skeExp = GetComponent<Skeleton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddExp( )
    {
        currentExp += skeExp.expSke  ;
        if( currentExp >= expToLevelUp)
        {
            LevelUp();
        }    
    } 

    public void LevelUp()
    {
        level++;
        expToLevelUp = (int)(expToLevelUp * 1.5f);
        UpdateUI();
    }    
        
    public void UpdateUI()
    {
        levelText.text = "Level: " + level.ToString();
        expText.text = "Exp: " + currentExp.ToString() + "/" + expToLevelUp.ToString();
    }    
}
