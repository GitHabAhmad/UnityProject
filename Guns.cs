using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GunsType{
	Sniper,Shotgun,Rifle
}
public class Guns : MonoBehaviour
{
	public GunsType gunsType = new GunsType();

	public Camera PlayerCamera;

	public GameObject ScopeOverlay;

	public bool IsScoping;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetAxis("Mouse ScrollWheel") > 0)
			NextWeapon();

		if (Input.GetAxis("Mouse ScrollWheel") < 0)
			PreviousWeapon();



		switch (gunsType)
		{
			case GunsType.Rifle:
				break;
			case GunsType.Shotgun:
				break;
			case GunsType.Sniper:
				Sniper();
				break;

		}
	}
	public void Sniper()
	{
		Zoom();
	}
	public void Zoom()
	{
		if (Input.GetMouseButtonDown(1) && !IsScoping)
		{
			ScopeOverlay.SetActive(true);
			PlayerCamera.fieldOfView = 15;
			IsScoping = true;
		}
		else if (Input.GetMouseButtonDown(1) && IsScoping)
		{
			ScopeOverlay.SetActive(false);
			PlayerCamera.fieldOfView = 60;
			IsScoping = false;
		}
	}
	void NextWeapon()
	{

	}
	void PreviousWeapon()
	{
 
	}
}
