using UnityEngine;
using System.Collections;

public class LerpMover : CameraMoverBase {

	public LerpMover (Vector3 toPosition, Quaternion toRotation, float threashold, OnComplete callback) : base(toPosition, toRotation, threashold, callback){
	}
		
	public override void Move(){
		Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, this.toPosition, Time.deltaTime);
		Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, this.toRotation, Time.deltaTime);

		if( (Camera.main.transform.position - this.toPosition).magnitude < this.threashold){
			CameraManager.DeleteCameraMoveEvent(this.Move);
			this.execCallback();
		}

	}
}
