using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputC : MonoBehaviour
{
    public static InputC instence;
    public Vector2 m_Movement;
    public Vector3 m_Camera;
    private void Awake()
    {
        instence = this;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        m_Movement.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        m_Camera.Set(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"),Input.GetAxis("Mouse ScrollWheel"));
    }
}
