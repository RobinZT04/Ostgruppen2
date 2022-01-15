

using UnityEngine;

// José Luis 
public class Door : MonoBehaviour
{
	Animator anim;			//Reference to the Animator component
	int openParameterID;	// We save in this variable the Hash from the variable "Open"


	void Start()
	{
		//Get a reference to the Animator component
		anim = GetComponent<Animator>(); // we access the animator reference 

		//Get the integer hash of the "Open" parameter. This is much more efficient
		//than passing strings into the animator
		openParameterID = Animator.StringToHash("Open"); // obtain the Hash parameter open 

		
		GameManager.RegisterDoor(this); // we tell the GameManager to register this door 
	}

	public void Open()
	{
		//Play the animation that opens the door
		anim.SetTrigger(openParameterID); // we establish the trigger from the parameter "Open"
		AudioManager.PlayDoorOpenAudio(); // we tell the AudioManager to reproduce the sound PlayDoorOpen
	}
}
