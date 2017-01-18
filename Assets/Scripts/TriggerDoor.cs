using UnityEngine;
using System.Collections;

public class TriggerDoor : InteractiveObject 
{
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("OnTriggerEnter");
			this.TriggerInteraction();
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Debug.Log("OnTriggerExit");
			this.TriggerInteraction();
		}
	}
}
