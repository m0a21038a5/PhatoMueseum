using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision collision)
    {
        //�ו��̃^�ORope�ɓ�����Ɣj��
        if (collision.gameObject.CompareTag("Rope"))
        {
            
            //�ו��̎x���̃^�OLoadSupport�Ɖו��̃^�ORope�Əe�̃J�����̃^�OBulletCamera���l��
            GameObject load1 = GameObject.FindGameObjectWithTag("LaodSupport");
            GameObject Rope1 = GameObject.FindGameObjectWithTag("Rope");
            GameObject BulletCamera1 = GameObject.FindGameObjectWithTag("BulletCamera");
            GameObject Shootdownarea1 = GameObject.FindGameObjectWithTag("Shootdownarea");
            GameObject Shootdownoperation = GameObject.FindGameObjectWithTag("ShootdownUI");
            Destroy(load1);
            Destroy(Rope1);
            Destroy(BulletCamera1);
            Destroy(Shootdownarea1);
            Destroy(Shootdownoperation);
            Destroy(this.gameObject);
            
        }
    }
}

