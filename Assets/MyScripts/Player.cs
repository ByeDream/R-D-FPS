using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Player : MonoBehaviour {

    private RigidbodyFirstPersonController mFPSController;

    public Animator mAnimator;

    public Transform mShotPoint;

    // Use this for initialization
    void Start () {
        mFPSController = this.GetComponent<RigidbodyFirstPersonController>();
        mFPSController.movementSettings.MoveInputCallBack = OnMoveInputCallBack;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            OnShoot();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            OnStopShoot();
        }
    }

    void OnShoot()
    {
        mAnimator.SetBool("Shoot", true);
    }

    void OnStopShoot()
    {
        mAnimator.SetBool("Shoot", false);
    }

    public void OnBullet()
    {

    }

    void OnMoveInputCallBack(Vector2 input)
    {
        mAnimator.SetFloat("X", input.x);
        mAnimator.SetFloat("Y", input.y);
    }
}
