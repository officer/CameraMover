using UnityEngine;
using System.Collections;

public class SlerpMover : CameraMoverBase {
	public SlerpMover (Vector3 toPosition, Quaternion toRotation, float threashold, OnComplete callback) : base(toPosition, toRotation, threashold, callback){
	}

	public override void Move(){
		Camera.main.transform.position = Vector3.Slerp(Camera.main.transform.position, this.toPosition, Time.deltaTime);
		Camera.main.transform.rotation = Quaternion.Slerp(Camera.main.transform.rotation, this.toRotation, Time.deltaTime);
		
		if( (Camera.main.transform.position - this.toPosition).magnitude < this.threashold){
			CameraManager.DeleteCameraMoveEvent(this.Move);
			this.execCallback();
		}

	}
}
