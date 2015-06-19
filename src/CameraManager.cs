using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour{

	public delegate void OnUpdate();

	/// <summary>
	/// Occurs when .
	/// </summary>
	public static event OnUpdate _updateEvent;

	// Update is called once per frame
	void Update () {
		if( null != _updateEvent){
			_updateEvent();
		}
	}


	/// <summary>
	/// Raises the game start event of camera moving.
	/// </summary>
	public static void RegisterCameraMoveEvent(Vector3  toPosition, Quaternion toRotation, float threashold = 0.1f, CameraMovementType movementType  = CameraMovementType.Direct, CameraMoverBase.OnComplete callback = null){

		CameraMoverBase mover = null;

		switch(movementType){
		case CameraMovementType.Direct:
			mover = new DirectMover(toPosition, toRotation, callback);
			break;


		case CameraMovementType.Lerp:
			mover = new LerpMover(toPosition, toRotation, threashold, callback);
			break;

		case CameraMovementType.Slerp:
			mover = new SlerpMover(toPosition, toRotation, threashold, callback);
			break;
		}

		_updateEvent = mover.Move;
	}

	
	public static void DeleteCameraMoveEvent(OnUpdate callableDelegate){
		_updateEvent -= callableDelegate;
	}
}
