using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;

public class DialogueManager : MonoBehaviour {

	public GameObject dialogueBox;
	public Text dialogueText;

	public UnityChanControlScriptWithRgidBody player;

	public bool dialogueActive;

	public bool talkingtoSaphire;

	public string[] dialogueLines;

	public int currentLine; 

	void Start() 
	{
		dialogueBox.SetActive (false);
		dialogueText.text = "";
	}

	void Update () {
		
		if (dialogueActive && Input.GetKeyDown(KeyCode.Return)) {

			//player.movementSettings.BackwardSpeed = 4f;
			//player.movementSettings.ForwardSpeed = 8f;
			//player.movementSettings.StrafeSpeed = 4f;

			currentLine++;

			if (currentLine >= 7 && talkingtoSaphire == true) {

				dialogueActive = false;
				dialogueBox.SetActive (false);
				dialogueBox.SetActive (false);
			}

		}

		else if (currentLine >= dialogueLines.Length) { 
			
			dialogueBox.SetActive (false);
			dialogueBox.SetActive (false);

			currentLine = 0;

		} else if (dialogueActive) {
			dialogueText.text = dialogueLines [currentLine];
		}

	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "DialogueTrigger1") {

			currentLine = 0;

			dialogueActive = true;
			talkingtoSaphire = true;
			dialogueBox.SetActive (true);

			//player.movementSettings.BackwardSpeed = 0f;
			//player.movementSettings.ForwardSpeed = 0f;
			//player.movementSettings.StrafeSpeed = 0f;


		}

	}

	void OnTriggerExit(Collider other) {

		talkingtoSaphire = false;

	}
}
			
	 