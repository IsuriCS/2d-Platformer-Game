using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int numberOfCoins ;
    public TextMeshProUGUI coinText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: "+numberOfCoins;
    }
}
