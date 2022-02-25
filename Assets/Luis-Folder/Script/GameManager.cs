

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	
	static GameManager current;
								
	SceneFader sceneFader;                      //The scene fader


    public AudioSource audioSource; //A primary audioSource a large portion of game sounds are passed through
    public DialogueBoxController dialogueBoxController;
    public HUD hud; //A reference to the HUD holding your health UI, coins, dialogue, etc.
    public Dictionary<string, Sprite> inventory = new Dictionary<string, Sprite>();
    private static GameManager instance;
   

    public static void RegisterSceneFader(SceneFader fader)
	{
	
		if (current == null)
			return;

		//Record the scene fader reference
		current.sceneFader = fader; // if the GameManager is in the scene the current value will execute to the scenef
	}

    // Singleton instantiation
    public static GameManager Instance
    {
        get
        {
            if (instance == null) instance = GameObject.FindObjectOfType<GameManager>();
            return instance;
        }
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Use this for initialization
    public void GetInventoryItem(string name, Sprite image)
    {
        inventory.Add(name, image);

        if (image != null)
        {
            //hud.SetInventoryImage(inventory[name]);
        }
    }

    public void RemoveInventoryItem(string name)
    {
        inventory.Remove(name);
     //   hud.SetInventoryImage(hud.blankUI);
    }

    public void ClearInventory()
    {
        inventory.Clear();
       // hud.SetInventoryImage(hud.blankUI);
    }









}
