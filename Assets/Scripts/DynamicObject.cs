using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class DynamicObject{

	public int id;
	public string type;
	public Vector2 position;
	public Quaternion rotation;
	public Vector3 linearVelocity;
	public float angularVelocity;
	public string ownedBy = "";

	public void setValues(int id,string type,Vector2 position,Quaternion rotation,Vector3 linearVelocity,float angularVelocity){
		this.id = id;
		this.type = type;
		this.position = position;
		this.rotation = rotation;
		this.linearVelocity = linearVelocity;
		this.angularVelocity = angularVelocity;
	}

	public void setValues(string type,Vector2 position,Quaternion rotation,Vector3 linearVelocity,float angularVelocity){
		this.type = type;
		this.position = position;
		this.rotation = rotation;
		this.linearVelocity = linearVelocity;
		this.angularVelocity = angularVelocity;
	}

	public void setValues(Vector2 position,Quaternion rotation,Vector3 linearVelocity,float angularVelocity){
		this.position = position;
		this.rotation = rotation;
		this.linearVelocity = linearVelocity;
		this.angularVelocity = angularVelocity;
	}

}
