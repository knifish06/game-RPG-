using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private HealthManager healthMan;
    public Slider healthBar;
    public Text hpText;

    private SystemLevel expPlayer;
    public Slider ExpBar;
    public Text expText;

    // Start is called before the first frame update
    void Start()
    {
        healthMan = FindObjectOfType<HealthManager>();
        expPlayer = FindObjectOfType<SystemLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.maxValue = healthMan.maxHealth;
        healthBar.value = healthMan.curentHealth;

        hpText.text = "HP: " + healthMan.curentHealth + "/" + healthMan.maxHealth;

        ExpBar.maxValue = expPlayer.expToLevelUp;
        ExpBar.value = expPlayer.currentExp;

        expText.text = "Exp: " + expPlayer.currentExp + "/" + expPlayer.expToLevelUp;

    }
}
