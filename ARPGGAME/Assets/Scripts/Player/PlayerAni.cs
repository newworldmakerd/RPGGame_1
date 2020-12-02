using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAni : MonoBehaviour
{
    public Animator ani;
    InputC m_Input;
    private void Awake()
    {
        m_Input = FindObjectOfType<InputC>();
        ani = this.transform.GetChild(0).GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        ani.SetFloat("horizontal", m_Input.m_Movement.x);
        ani.SetFloat("vertical", Mathf.Abs( m_Input.m_Movement.y));
    }
}
