using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleObjectMover : MonoBehaviourPun
{
    [SerializeField]
    private float _moveSpeed = 1f;

    private Animator _animator;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (base.photonView.IsMine)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            transform.position += (new Vector3(x, y, 0f) * _moveSpeed);

            UpdateMOvingBoolean((x != 0f || y != 0f));
                

        }   
    }
    private void UpdateMOvingBoolean(bool moving)
    {
        _animator.SetBool("Moving", moving);
    }
}
