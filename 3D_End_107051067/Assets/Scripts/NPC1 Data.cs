
using UnityEngine;
[CreateAssetMenu(fileName = "NPC資訊1", menuName = "IceTalker/NPC資料")]

public class NPCData1 : ScriptableObject
{
    [Header("第一段對話"), TextArea(1, 8)]
    public string dialougA;
    [Header("第二段對話"), TextArea(1, 5)]
    public string dialougB;
    [Header("第三段對話"), TextArea(1, 5)]
    public string dialougC;

    [Header("任務項目需求數量")]
    public int count;
    [Header("已取得項目需求數量")]
    public int countCurrent;
}
