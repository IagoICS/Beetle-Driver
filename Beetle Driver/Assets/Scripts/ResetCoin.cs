using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCoin : MonoBehaviour
{
    void Start()
    {
        // Redefina as PlayerPrefs para a contagem de moedas começar em zero
        PlayerPrefs.SetInt("ScoreCoin", 0);
        PlayerPrefs.Save();
    }
}