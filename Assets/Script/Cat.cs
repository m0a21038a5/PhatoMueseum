using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameObject phantom;
    public float Jumppower;//  ジャンプ力
    int jumpCount = 0;
    private Rigidbody rb;//  Rigidbodyを使うための変数
    private bool Grounded;//  地面に着地しているか判定する変数
    private bool Super;
    [SerializeField] private Vector3 velocity;              // 移動方向
    [SerializeField] private float moveSpeed = 5.0f;        // 移動速度
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
       
        // 速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整します
        velocity = velocity.normalized * moveSpeed ;

        // いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            // プレイヤーの位置(transform.position)の更新
            // 移動方向ベクトル(velocity)を足し込みます
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

    private void OnCollisionEnter(Collision other)//  地面に触れた時の処理
    {
        if (other.gameObject.tag == "Ground")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            Grounded = true;//  Groundedをtrueにする
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
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }
}