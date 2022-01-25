using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [Header("Reference")]
    public Animator animator;

    public TextMeshProUGUI coinsMesh;
 
    [SerializeField] private Image inventoryItemGraphic;
    [SerializeField] private GameObject startUp;

    [System.NonSerialized] public Sprite blankUI; // The sprite that is shown in the UI when you don't have any items
    private float coins;
    private float coinsEased;



    void Start()
    {
        //Set all bar widths to 1, and also the smooth variables.
       
        coins = (float)NewPlayer.Instance.coins;
        coinsEased = coins;
        blankUI = inventoryItemGraphic.GetComponent<Image>().sprite;
    }

    void Update()
    {
        //Update coins text mesh to reflect how many coins the player has! However, we want them to count up.
        coinsMesh.text = Mathf.Round(coinsEased).ToString();
        coinsEased += ((float)NewPlayer.Instance.coins - coinsEased) * Time.deltaTime * 5f;

        if (coinsEased >= coins)
        {
            animator.SetTrigger("getGem");
            coins = coinsEased + 1;
        }

       

    }

    public void HealthBarHurt()
    {
        animator.SetTrigger("hurt");
    }

    public void SetInventoryImage(Sprite image)
    {
        inventoryItemGraphic.sprite = image;
    }

    
}
