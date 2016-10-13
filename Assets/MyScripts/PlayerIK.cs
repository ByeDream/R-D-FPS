using UnityEngine;
using System.Collections;

public class PlayerIK : MonoBehaviour {

    public Transform mLookAtTarge;

    private Animator mAnimator;

    void Awake()
    {
        mAnimator = this.GetComponent<Animator>();
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnAnimatorIK(int layerIndex)
    {
        if(mAnimator != null)
        {
            mAnimator.SetLookAtWeight(1, 1, 1, 1);

            if(mLookAtTarge != null)
            {
                mAnimator.SetLookAtPosition(mLookAtTarge.position);
            }

        }
    }
}
