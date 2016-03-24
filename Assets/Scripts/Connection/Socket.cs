using UnityEngine;
using System.Collections;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

public class Socket : MonoBehaviour {

	public UdpClient client;
	public IPAddress serverIp;
	public string hostIp;
	public int hostPort;
	public IPEndPoint hostEndPoint;

	void Start(){
		serverIp = IPAddress.Parse(hostIp);
		hostEndPoint = new IPEndPoint(serverIp,hostPort);

		client = new UdpClient();
		client.Connect(hostEndPoint);
		client.Client.Blocking = false;
	}

	public void SendDgram(string evento,string msg){
		byte[] dgram = Encoding.UTF8.GetBytes(evento+"_"+msg);
		client.Send(dgram,dgram.Length);
		client.BeginReceive(new AsyncCallback(processDgram),client);
	}

	public void processDgram(IAsyncResult res){
		try {
			byte[] recieved = client.EndReceive(res,ref hostEndPoint);
			Debug.Log(Encoding.UTF8.GetString(recieved));
		} catch (Exception ex) {
			throw ex;
		}
	}

	void OnGUI()
	{
		if(GUI.Button (new Rect (10,10,100,40), "Send"))
		{
			DynamicObject d = new DynamicObject();
			SendDgram("JSON",JsonUtility.ToJson(d).ToString());
		}
	}



}
