//SUMMARY FOR HENRY
// This script is a Manager that controls the the flow and control of the game. It keeps
// track of player data (orb count, death count, total game time) and interfaces with
// the UI Manager. All game commands are issued through the static methods of this class

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	//This class holds a static reference to itself to ensure that there will only be
	//one in existence. This is often referred to as a "singleton" design pattern. Other
	//scripts access this one through its public static methods
	static GameManager current;

	public float deathSequenceDuration = 1.5f;	//How long player death takes before restarting

	List<Orb> orbs;								//The collection of scene orbs
	Door lockedDoor;							//The scene door
	SceneFader sceneFader;						//The scene fader

	int numberOfDeaths;							//Number of times player has died
	float totalGameTime;						//Length of the total game time
	bool isGameOver;							//Is the game currently over?


	void Awake()
	{
		// if it alreayd has a value the current variable then it means that previously, a value had already been assigned to it from another GameManager component
		if (current != null && current != this) // if it has a value and the value it had is not the component that is running now 
			
		{
			
			Destroy(gameObject); // then we destory the gameobejct gameMaanger new. Meaning that we will be staying with the first one that was executed 
			return;
		}

		
		current = this; // then we register it and tell it to save the reference this/ours in the variable current

		//Create out collection to hold the orbs
		orbs = new List<Orb>(); // we creat an empty list which will contain the orbs, cheese the player will have to pick

		//Persis this object between scene reloads
		DontDestroyOnLoad(gameObject); //then we mark the object DontDestroyOnLoad so that so that the object where this component is wont be destroyed when another scene or the same scene is loading .
	}

	void Update()
	{
		// execute in the update when it has not yet been lost, since if the game over has been lost, the execution of the update ends
		if (isGameOver)
			return;

		//Update the total game time and tell the UI Manager to update
		totalGameTime += Time.deltaTime; // If the player has not lost, then we accumulate with the most equal the time of this last frame in a variable that will have the time we have been playing
		UIManager.UpdateTimeUI(totalGameTime); // we tell the UI manager to update the value of the time and the seconds that we have been playing
	}

	public static bool IsGameOver()
	{
		//If there is no current Game Manager, return false 
		if (current == null) // we check if no value has been asigned to the current, it's because there is no game manager is in the scene 
			return false; // we return it false 

		//Return the state of the game
		return current.isGameOver; // if we have a value in current then we return the isGameOver from the component current gameManager
	}

	public static void RegisterSceneFader(SceneFader fader)
	{
	
		if (current == null)
			return;

		//Record the scene fader reference
		current.sceneFader = fader; // if the GameManager is in the scene the current value will execute to the scenef
	}

	public static void RegisterDoor(Door door)
	{

		if (current == null) // if the variable still does not have a value 
			return; // then we just return 

		//Record the door reference
		current.lockedDoor = door;
	}

	public static void RegisterOrb(Orb orb)
	{
		//If there is no current Game Manager, exit
		if (current == null)
			return;

		//If the orb collection doesn't already contain this orb, add it
		if (!current.orbs.Contains(orb)) // if i don't have you in the list
			current.orbs.Add(orb); // i will have to add it to the list of items that the user will have to take 

		//Tell the UIManager to update the orb text
		UIManager.UpdateOrbUI(current.orbs.Count); // I tell the UIManager to show me the total of orbs that i have in the list. Which will be the total of the orbs that the player will have to take to open the door 
	}

	public static void PlayerGrabbedOrb(Orb orb)
	{
		
		if (current == null) // if there is no gameManager 
			return; // then we return

		
		if (!current.orbs.Contains(orb)) // if the list of the orbs does not contain the specific orb that we just took 
			return; // then we will also return, so we don't do a thing cause it's the program that does all the work (;

		//Remove the collected orb
		// if the conditions are meet 
		current.orbs.Remove(orb); // then we eliminate the orb that we have passed to it by parameter that has been the one that was taken to eliminate it from the list

		//If there are no more orbs, tell the door to open
		if (current.orbs.Count == 0) // after eliminating it we check if the list already has zero elements, that is to say that the user has taken all the orbs
			current.lockedDoor.Open(); // then we say to the door to open

		//Tell the UIManager to update the orb text
		UIManager.UpdateOrbUI(current.orbs.Count); // We also tell the user  UImanager to update the counter of the number of orbs left to catch, thus passing the count of orbs left in that list to the pending enlisters that the user has to catch.
	}

	public static void PlayerDied()
	{
		//If there is no current Game Manager, exit
		if (current == null)
			return; // we do nothing 

		//Increment the number of player deaths and tell the UIManager
		current.numberOfDeaths++; 
		UIManager.UpdateDeathUI(current.numberOfDeaths); 

		//If we have a scene fader, tell it to fade the scene out
		if(current.sceneFader != null)
			current.sceneFader.FadeSceneOut();

		//Invoke the RestartScene() method after a delay
		current.Invoke("RestartScene", current.deathSequenceDuration);
	}

	public static void PlayerWon()
	{
		//If there is no current Game Manager, exit
		if (current == null)
			return;

		//The game is now over
		current.isGameOver = true;

		//Tell UI Manager to show the game over text and tell the Audio Manager to play
		//game over audio
		UIManager.DisplayGameOverText();
		AudioManager.PlayWonAudio();
		// will ADD SO THAT WE CHANGE SCENE WHEN WE WIN
	}

	void RestartScene()
	{
		//Clear the current list of orbs
		orbs.Clear();

		//Play the scene restart audio
		AudioManager.PlaySceneRestartAudio();

		//Reload the current scene
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
	}
}
