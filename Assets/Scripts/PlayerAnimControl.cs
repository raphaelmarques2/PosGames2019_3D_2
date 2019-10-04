using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControl : MonoBehaviour
{

    Animator animator;
    
    private bool m_walk;
    public bool walk
    {
        get { return m_walk; }
        set
        {
            m_walk = value;
            animator.SetBool("Walk", m_walk);
        }
    }
    
    public void Jump()
    {
        animator.SetTrigger("Jump");
    }
    
    private float m_speed;
    public float speed {
        get { return m_speed; }
        set
        {
            m_speed = Mathf.Clamp(value, 0, 1);
            animator.SetFloat("Speed", m_speed);
        }
    }
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

}
