using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameObject phantom;
    public float Jumppower;//  �W�����v��
    int jumpCount = 0;
    private Rigidbody rb;//  Rigidbody���g�����߂̕ϐ�
    private bool Grounded;//  �n�ʂɒ��n���Ă��邩���肷��ϐ�
    private bool Super;
    [SerializeField] private Vector3 velocity;              // �ړ�����
    [SerializeField] private float moveSpeed = 5.0f;        // �ړ����x
    [SerializeField] private float jumpPower = 5.0f;
    float dashSpeed = 0.05f;

    float inputHorizontal;
    float inputVertical;

    private Animator animator;

    private string Walk = "isWalk";
    private string Run = "isRun";
    private string Jump = "isJump";
   

    public float countdown = 30.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        this.animator = GetComponent<Animator>();
    }
    void Update()
    {


        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (jumpCount < 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Grounded = false;
            rb.AddForce(Vector3.up * Jumppower);
            jumpCount++;
            this.animator.SetBool(Jump, true);
        }
       
        // ���x�x�N�g���̒�����1�b��moveSpeed�����i�ނ悤�ɒ������܂�
        velocity = velocity.normalized * moveSpeed ;

        // �����ꂩ�̕����Ɉړ����Ă���ꍇ
        if (velocity.magnitude > 0)
        {
            // �v���C���[�̈ʒu(transform.position)�̍X�V
            // �ړ������x�N�g��(velocity)�𑫂����݂܂�
            transform.position += velocity;
        }
        if (Super == true)
        {
            countdown -= Time.deltaTime;
            Debug.Log(countdown);
            if (countdown <= 0)
            {
                Jumppower = 300;
                moveSpeed = 5.0f;
                Super = false;
                countdown = 30.0f;
            }
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

    }

    private void OnCollisionEnter(Collision other)//  �n�ʂɐG�ꂽ���̏���
    {
        if (other.gameObject.tag == "Ground")//  ����Ground�Ƃ����^�O�������I�u�W�F�N�g�ɐG�ꂽ��A
        {
            Grounded = true;//  Grounded��true�ɂ���
            jumpCount = 0;
            this.animator.SetBool(Jump, false);
        }

        if (other.gameObject.tag == "Churu")
        {
            Jumppower = 1200;
            moveSpeed = 10.0f;
            Super = true;
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
}