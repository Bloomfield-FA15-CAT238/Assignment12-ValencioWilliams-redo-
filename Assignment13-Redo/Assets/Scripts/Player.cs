using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	[SyncVar]
	public Color color;
	
	//NetworkServer.AddPlayerForConnection(conn, playerToSpawn, playerControllerId);
	//playerToSpawn.GetComponent<Renderer>().material.color = color;
	
	public override void OnStartClient() {
		gameObject.GetComponent<Renderer>().material.color = color;
	
	}






}

	

