using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phantom : MonoBehaviour
{
    public GameObject cat;
    public GameObject weight;
    public GameObject weight_01;
    public GameObject stopper;
    public GameObject weightUI;
    public GameObject seesawUI;
    public AudioClip TakeGem;
    AudioSource audioSouce;

    public GameObject seesawOperation;
    public GameObject weightOperation;

    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;
   
    private Animator animator;
   

    private string Walk = "isWalk";
    private string Run = "isRun";
  

    float moveSpeed = 5.0f ;
    float dashSpeed = 0.05f;

    int weightCount = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        this.animator = GetComponent<Animator>();
        audioSouce = GetComponent<AudioSource>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (weightCount == 1 && Input.GetKeyDown(KeyCode.J))
        {
            weight_01.SetActive(true);
            stopper.SetActive(false);
            Destroy(seesawOperation);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.animator.SetBool(Walk, true);
        }
        else
        {
            this.animator.SetBool(Walk, false);
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftShift))
        {
            this.animator.SetBool(Run, true);
            moveSpeed = moveSpeed + dashSpeed;
        }
        else
        {
            this.animator.SetBool(Run, false);
            moveSpeed = 5.0f;
        }

        if (weightCount < 1 && Input.GetKeyDown(KeyCode.J))
        {
            Destroy(weight);
            weightCount++;
            Destroy(weightOperation);
            audioSouce.PlayOneShot(TakeGem);
        }
    }



    void FixedUpdate()
    {

        // �J�����̕�������AX-Z���ʂ̒P�ʃx�N�g�����擾
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // �����L�[�̓��͒l�ƃJ�����̌�������A�ړ�����������
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // �ړ������ɃX�s�[�h���|����B�W�����v�◎��������ꍇ�́A�ʓrY�������̑��x�x�N�g���𑫂��B
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

        // �L�����N�^�[�̌�����i�s������
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }

    }


    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name == "weightUI")
        {
            weightOperation.SetActive(true);
        }

        if (collision.gameObject.name == "SeesawUI")
        {
            seesawOperation.SetActive(true);
        }

    }
}