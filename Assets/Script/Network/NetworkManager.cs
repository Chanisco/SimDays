using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	private const string typeName = "UniqueGameName";
	private const string gameName = "WalkRoom";

	private HostData[] hostList;
	private Rect buttonRect = new Rect(100,100,250,100);

	private void StartServer(){
		Network.InitializeServer(4,1337,!Network.HavePublicAddress());
		MasterServer.RegisterHost(typeName,gameName);
	}

	void OnServerInitialized(){
		Debug.Log("Server Initialized");
	}

	void OnGUI(){
		if(!Network.isClient && !Network.isServer){
			if(GUI.Button(buttonRect,"StartServer")){
				StartServer();
			}
		}

	}

	private void RefreshHostList()
	{
		MasterServer.RequestHostList(typeName);
	}
	
	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if (msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList();
	}

	private void JoinServer(HostData hostdata){
		Network.Connect(hostdata);
	}

	void OnConnectedToServer(){
		Debug.Log("Server Joined");
	}
}
