using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxCamera : MonoBehaviour
{
    public static CinemachineBrain.BrainEvent CameraUpdatedEvent;

	public delegate void ParallaxCameraDelegate(float deltaMovement);
    public ParallaxCameraDelegate onCameraTranslate;

    private float oldPosition;

	void Start()
    {
        oldPosition = transform.position.x;
    }

    void FixedUpdate()
    {
        if (transform.position.x != oldPosition)
        {
            if (onCameraTranslate != null)
            {
                float delta = oldPosition - transform.position.x;
                onCameraTranslate(delta);
            }

            oldPosition = transform.position.x;
        }
	}
	private void OnEnable()
	{
		CinemachineCore.CameraUpdatedEvent.AddListener(CameraUpdate);
	}

	private void OnDisable()
	{
		CinemachineCore.CameraUpdatedEvent.RemoveListener(CameraUpdate);
	}

	private void CameraUpdate(CinemachineBrain arg0)
	{
        FixedUpdate();
	}
}