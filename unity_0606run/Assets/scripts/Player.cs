using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*    欄位語法
     * 修飾詞 類型 欄位名稱 = 值;
     * 沒有=值
     * 整數&浮點數 預設值為0
     * 布林值 fause
     * 修飾詞種類  1 私人 private -僅限此類別使用| 在unity內不會顯示，此為預設值
     *             2 公開 public  -所有類別皆可使用|在unity內不會顯示
     * 
     * 欄位屬性將 [屬性名稱()]加在欄位的上一行
     * ex:
     *      標題 header
     *      提示 Tooktip
     *      範圍 Range
     */

    #region 欄位區域
    [Header("速度"), Tooltip("腳色的移動速度"), Range(0, 15)]
    public int speed = 10;
    [Tooltip("腳色血量")]
    public float hp = 999.9f;
    public int coin;
    [Tooltip("跳躍高度"),Range(50,500)]
    public int height = 50;
    [Tooltip("跳躍音效")]
    public AudioClip soundjp;
    [Tooltip("滑行音效")]
    public AudioClip soundslide;
    [Tooltip("受傷音效")]
    public AudioClip soundhit;
    [Tooltip("判斷是否死亡")]
    public bool liveOrDeath;
    [Tooltip("動畫控制器")]
    public Animator ani;
    [Tooltip("碰撞器")]
    public CapsuleCollider2D cc2d;
    [Tooltip("剛體")]
    public Rigidbody2D rig;
    #endregion


    #region 方法區域
    /*
     * 摘要:方法的說明
     * 在方法的上衣行添加三條/
     */
    /// <summary>
    /// 腳色的跳躍功能:跳躍動畫+跳躍音效
    /// </summary>
    public bool IsGround;
    /// <summary>
    /// 腳色移動
    /// </summary>
    private void move()
    {
        if (rig.velocity.magnitude<10) //velocity 加速度 
        {
        rig.AddForce(new Vector2(speed, 0));
        }
        
    }
    private void Jump()
    {
        bool jump = Input.GetKey(KeyCode.Space);
        ani.SetBool("jump switch", !IsGround);
        if (IsGround)
        {
            if (jump)
            {

                IsGround = false;
            rig.AddForce(new Vector2(0, height)); //剛體增加推力(二維向量)
            }
        }
    }
    /// <summary>
    /// 腳色的滑行功能:滑行動畫+滑行音效+縮小碰撞範圍
    /// </summary>
    private void Slide()
    {
        bool key = Input.GetKey(KeyCode.Z);
        ani.SetBool("slide switch", key);
        if (key)
        {
            cc2d.offset = new Vector2(-0.9796966f, -0.97f);
            cc2d.size = new Vector2(1.944118f, 1.91f);
        }
        else
        {
         cc2d.offset=new Vector2(-0.9796966f, 0.01935404f);
         cc2d.size=new Vector2(1.944118f, 3.585742f);
        }
       

    }
    /// <summary>
    /// 吃金幣:金幣數量增加+金幣消失+金幣音效
    /// </summary>
    private void EatCoin()
    {

    }
    /// <summary>
    /// 死亡:死亡動畫+跳出結算畫面
    /// </summary>
    private void Dead()
    {

    }
    /// <summary>
    /// 受傷:血條減少+受傷音效
    /// </summary>
    private void Hit()
    {

    }

    #endregion

# region 事件區域
    /*開始 start-遊戲開始時執行一次
     * 初始化之類的
     */
    
    /*
     * 更新 update
     * 開始遊戲後一秒執行約60次
     * 移動 監聽玩家鍵盤,滑鼠與觸控
     */
    
    private void Update()
    {
        Slide();
        
    }
    private void FixedUpdate()
    {
        Jump();
        move();
    }
    #endregion
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "地板" || gameObject.name=="漂浮地板" || gameObject.name == "其他物件" || gameObject.name == "雜物")
        {
            //是否在地板
            //搬家 選取後alt+上或下
            //格式化 ctrl+ kd
            IsGround = true;
        }

    }
}
