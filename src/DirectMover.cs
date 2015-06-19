using UnityEngine;
using System.Collections;

public class DirectMover : CameraMoverBase {

	public DirectMover  (Vector3 toPosition, Quaternion toRotation, OnComplete callback) : base( toPosition, toRotation, callback){
	}

		
	public override void Move(){
		Camera.main.transform.position = this.toPosition;
		Camera.main.transform.rotation = this.toRotation;

		this.execCallback();

	}
}
