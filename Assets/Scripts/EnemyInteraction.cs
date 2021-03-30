using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : Interactable
{
	protected override void Interact()
	{
		base.Interact();
		Debug.Log("Вы были затролены " + transform.name);
	}
}
