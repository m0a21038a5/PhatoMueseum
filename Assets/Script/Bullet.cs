using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision collision)
    {
        //荷物のタグRopeに当たると破壊
        if (collision.gameObject.CompareTag("Rope"))
        {
            
            //荷物の支えのタグLoadSupportと荷物のタグRopeと銃のカメラのタグBulletCameraを獲得
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

