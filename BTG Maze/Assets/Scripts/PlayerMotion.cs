using UnityEngine;
using System.Collections;

public class PlayerMotion : MonoBehaviour {

	Vector3 movement;
	float curSpeed;
	CharacterController controller;
	Animator anim;
	float speed = 10f;
	float rotation = 4f;

	void Awake() {
		anim = GetComponent<Animator> ();
		anim.SetBool ("IsDying", false);
	}

	void FixedUpdate() {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		controller = (CharacterController)GetComponent (typeof(CharacterController));
		transform.Rotate (0, h * rotation, 0);
		movement = transform.TransformDirection (Vector3.forward);
		curSpeed = speed + v;
		controller.SimpleMove (movement * curSpeed);
		Animating (h, v);
	}

	void Animating (float h, float v) {

			bool walking = h != 0f || v != 0f;

			anim.SetBool("IsWalking", walking);


		}
}