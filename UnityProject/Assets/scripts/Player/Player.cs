
using UnityEngine;

public class Player: MonoBehaviour
{
    // 定義欄位 Field
    // 修飾詞 欄位類型 欄位名稱 (指定 值)結尾
    // 預設 private 私人 (在屬性面板顯示)
    // public 公開 (在屬性面板顯示)
    [Header("速度"), Range(0f, 100f)]
    public float speed = 3.5f;                // 浮點數 - 結尾要有 f
    [Header("跳躍"), Range(100, 2000)]
    public int jump = 300;                    // 整數
    [Header("是否在地版上"), Tooltip("用來判定腳色是否在地板上。")]
    public bool isGround = false;             // 布林值 - true false
    [Header("腳色名稱")]
    public string _name = "HANS";             // 字串 需要用雙引號



    
}
