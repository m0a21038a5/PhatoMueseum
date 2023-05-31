using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCopy : MonoBehaviour
{
    public float shotSpeed;
    public AudioClip Silentgun;
    AudioSource audioSouce;
    // privateの状態でもInspector上から設定できるようにする
    [SerializeField]
    private GameObject shellPrefab;

    private void Start()
    {
        audioSouce = GetComponent<AudioSource>();
    }
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            // 銃弾のプレハブを実体化
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, 180, transform.parent.eulerAngles.z));
            // 銃弾に付いているRigidbodyコンポーネントにアクセス
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            // forward（青軸＝Z軸）の方向に力を加える。
            shellRb.AddForce(transform.forward * -shotSpeed);
            // 発射した銃弾を8秒後に破壊する。
            Destroy(shell, 3.0f);
            audioSouce.PlayOneShot(Silentgun);
        }
    }
}
