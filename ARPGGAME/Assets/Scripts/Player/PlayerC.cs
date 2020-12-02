using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    public CharacterController characterController;
    public float walkSpeed;
    InputC m_Input;
    public static PlayerC playerC;
    private void Awake()
    {
        playerC = this;
        characterController = GetComponent<CharacterController>();
        m_Input = FindObjectOfType<InputC>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 dir = transform.TransformDirection(new Vector3( m_Input.m_Movement.x, 0, m_Input.m_Movement.y));
        characterController.Move(dir*walkSpeed*Time.deltaTime);
    }
}
