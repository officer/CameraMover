using UnityEngine;
using System.Collections;

public abstract class CameraMoverBase{
	// Position definition.
	protected Quaternion toRotation;
	
	// Rotation definition.
	protected Vector3 toPosition;
	
	// Threashold of end of the movement.
	protected float threashold;
	
	// Callback function
	public delegate void OnComplete();
	protected OnComplete callback;
	
	// function registered as a event
	public abstract void Move();

	public CameraMoverBase ()
	{
	}

	public CameraMoverBase (Vector3 toPosition, Quaternion toRotation, OnComplete callback)
	{
		this.toRotation = toRotation;
		this.toPosition = toPosition;
		this.callback = callback;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="CameraMoverBase"/> class.
	/// </summary>
	/// <param name="toRotation">To rotation.</param>
	/// <param name="toPosition">To position.</param>
	/// <param name="threashold">Threashold.</param>
	public CameraMoverBase (Vector3 toPosition, Quaternion toRotation, float threashold, OnComplete callback)
	{
		this.toRotation = toRotation;
		this.toPosition = toPosition;
		this.threashold = threashold;
		this.callback = callback;
	}
	
	protected void execCallback(){
		if( null != this.callback){
			this.callback();
		}
	}
}
