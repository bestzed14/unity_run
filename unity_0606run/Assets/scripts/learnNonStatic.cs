using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnNonStatic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject zonbie;
    public Transform zonbieTran;
    public Camera cam;
    public ParticleSystem kirakira;

    //靜態與非靜態的差異
    //非靜態需要有物件或元件
    private void Start()
    {
        //取得
        print(zonbie.tag);
        print(zonbie.layer);
        //存放
        zonbieTran.position = new Vector3(0, 7, 0);

    }


    void Update()
    {
        //非靜態方法
        zonbieTran.Translate(0.1f, 0, 0);
    }
}
