using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour {

    private RigidbodyFirstPersonController mFPSController;

    public Animator mAnimator;

    // Use this for initialization
    void Start () {
        mFPSController = this.GetComponent<RigidbodyFirstPersonController>();
        mFPSController.movementSettings.MoveInputCallBack = OnMoveInputCallBack;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMoveInputCallBack(Vector2 input)
    {
        mAnimator.SetFloat("X", input.x);
        mAnimator.SetFloat("Y", input.y);
    }
}
