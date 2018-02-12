using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent (typeof (Animator))]
public class PlayerMovement : MonoBehaviour
{
	Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator> ();
	}

	void Update()
	{
		Move ();
	}

	void Move()
	{
		anim.SetFloat ("Forward", Input.GetAxisRaw("Vertical"));
	}

}
