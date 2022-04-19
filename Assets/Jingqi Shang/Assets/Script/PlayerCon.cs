using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCon : MonoBehaviour
{
    private CharacterController controller;
    public float Speed = 15f;
    public float RotateSpeed = 1f;
    public Text scoreText;
    public int score;
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
       controller = transform.GetComponent<CharacterController>();
       m_Animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        MoveLike();
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        m_Animator.SetBool("isWalking", isWalking);
    }

    private void MoveLike() {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var move = transform.forward * Speed * vertical * Time.deltaTime;
        controller.Move(move);

        transform.Rotate(Vector3.up, horizontal * RotateSpeed);

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Food")
        {
            Destroy(collider.gameObject);
            score++;
            scoreText.text = "Score：" + score;
        }
    }
}
