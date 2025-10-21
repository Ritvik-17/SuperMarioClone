using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    private TMP_Text CountText;
    private int CoinCount = 0;

    void Start()
    {
        CountText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        
    }

    public void IncrementCoinCount()
    {
        CoinCount++;
        CountText.text = "Coins: " + CoinCount.ToString();
    }
}
