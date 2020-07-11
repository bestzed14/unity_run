using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learn1 : MonoBehaviour
{
    
    private void Start()
    {
        /*
         * 靜態成員用法
         * 靜態屬性 property=欄位 field(儲存欄位)
         * 語法:類別名稱 靜態屬性名稱
         */
        //print(Mathf.Deg2Rad);
        //print(Random.value);
        //print(Time.time);
        print(Random.Range(100, 501));
        test();
        Skill("升龍拳");
    }

    public void test()
            {
                print("測試用");
            }
    public void Skill(string s)
    {
        print("施放技能:" + s);
        print("播放音效:" + s);
    }
}
