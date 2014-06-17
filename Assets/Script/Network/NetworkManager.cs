using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

	private const string typeName = "UniqueGameName";
	private const string gameName = "WalkRoom";

	private HostData[] hostList;
	private Rect startBtnRect = new Rect(100,100,250,100);
	private Rect refreshBtnRect = new Rect(100,200,250,100);

	private bool refreshing;

	private void StartServer(){
		Network.InitializeServer(4,25000,!Network.HavePublicAddress());
		MasterServer.RegisterHost(typeName,gameName,"Now lets run");
	}

	private void RefreshHostList(){
		MasterServer.RequestHostList(typeName);
		refreshing = true;
	
	}


	void OnServerInitialized(){
		Debug.Log("Server Initialized");
	}


	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if (msEvent == MasterServerEvent.RegistrationSucceeded){
			Debug.Log("Registerede Server");
			//hostList = MasterServer.PollHostList();
		}
	}
	
	private void JoinServer(HostData hostdata){
		Network.Connect(hostdata);
	}
	
	void OnConnectedToServer(){
		Debug.Log("Server Joined");
	}


	void Update(){
		if(refreshing){
			if(MasterServer.PollHostList().Length > 0){
				refreshing = false;
				Debug.Log(MasterServer.PollHostList().Length);
			}
		}
	}
	void OnGUI(){
	//	if(!Network.isClient && !Network.isServer){
			if(GUI.Button(startBtnRect,"StartServer")){
				StartServer();
			}
			if(GUI.Button(refreshBtnRect,"Refresh")){
				RefreshHostList();
			}
			/*if(hostList != null){
				for(int i = 0; i < hostList.Length; i++){
					if (GUI.Button(new Rect(400, 100 + (110 * i), 300, 100), hostList[i].gameName))
						JoinServer(hostList[i]);
				}
			}*/
	//	}

	}



}
