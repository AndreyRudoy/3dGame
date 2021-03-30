using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractable : Interactable
{
	public override float StoppingDistance
	{
		get { return _interactionDistance * 0.1f; }
	}

	protected override void Interact()
	{
		base.Interact();
		Debug.Log("Сори, не судьба тебе поднять это " + transform.name);
	}
}
