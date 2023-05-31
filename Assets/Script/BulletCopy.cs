using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCopy : MonoBehaviour
{
    public float shotSpeed;
    public AudioClip Silentgun;
    AudioSource audioSouce;
    // private�̏�Ԃł�Inspector�ォ��ݒ�ł���悤�ɂ���
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
            // �e�e�̃v���n�u�����̉�
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, 180, transform.parent.eulerAngles.z));
            // �e�e�ɕt���Ă���Rigidbody�R���|�[�l���g�ɃA�N�Z�X
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            // forward�i����Z���j�̕����ɗ͂�������B
            shellRb.AddForce(transform.forward * -shotSpeed);
            // ���˂����e�e��8�b��ɔj�󂷂�B
            Destroy(shell, 3.0f);
            audioSouce.PlayOneShot(Silentgun);
        }
    }
}
