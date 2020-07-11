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
    [Header("速度"),Tooltip("腳色的移動速度"),Range(50,150)]
    public int speed=50;
    [Tooltip("腳色血量")]
    public float hp=999.9f;
    public int coin;
    [Tooltip("跳躍高度")]
    public int height;
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
    #endregion

    
    #region 方法區域
    /*
     * 摘要:方法的說明
     * 在方法的上衣行添加三條/
     */
    /// <summary>
    /// 腳色的跳躍功能:跳躍動畫+跳躍音效
    /// </summary>
    private void Jump()
    {
        print("jump啟動!!");
    }
    /// <summary>
    /// 腳色的滑行功能:滑行動畫+滑行音效+縮小碰撞範圍
    /// </summary>
    private void Slide()
    {
        bool key = Input.GetKey(KeyCode.Z);
        ani.SetBool("slide switch", key);
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
    private void Start()
    {
       
    }
    /*
     * 更新 update
     * 開始遊戲後一秒執行約60次
     * 移動 監聽玩家鍵盤,滑鼠與觸控
     */
    private void Update()
    {
        Slide();
    }
    #endregion
}
