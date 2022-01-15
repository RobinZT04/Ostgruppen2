//quick summary for HENRY
// This script controls the orb collectables. It is responsible for detecting collision
// with the player and reporting it to the game manager. Additionally, since the orb
// is a part of the level it will need to register itself with the game manager
//JOSÉ LUIS
using UnityEngine;

public class Orb : MonoBehaviour
{
	public GameObject explosionVFXPrefab;	//The visual effects for orb collection

	int playerLayer;// A private int that will reference to the void start					


	void Start()
	{
 
		playerLayer = LayerMask.NameToLayer("Player"); // we just check if the layername "Player" hits the colider 

		//Register this orb with the game manager
		GameManager.RegisterOrb(this); // the orb tells the game manager register me and it will pass itself as an reference 
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		
		//efficient than string comparisons using Tags in my opinion (;
		if (collision.gameObject.layer != playerLayer) // if the layer that belongs to the object that has entered in the eara of the colider is not the player layer 
			return; // then we just return 

		//The orb has been touched by the Player, so instantiate an explosion prefab
		//at this location and rotation
		Instantiate(explosionVFXPrefab, transform.position, transform.rotation); // if it is an object that belongs to the player layer then we distance the explosion, the prefab that contains the explosion 
		
		//Tell audio manager to play orb collection audio
		AudioManager.PlayOrbCollectionAudio(); // we tell the audioManager to play the sound  for collecting orbs 

		//Tell the game manager that this orb was collected
		GameManager.PlayerGrabbedOrb(this); // we tell the gameManager that it has been taken, the specific orb

		//Deactivate this orb to hide it and prevent further collection
		gameObject.SetActive(false);
	}
}
