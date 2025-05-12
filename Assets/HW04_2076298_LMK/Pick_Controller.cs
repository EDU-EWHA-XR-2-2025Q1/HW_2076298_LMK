using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pick_Controller : MonoBehaviour
{
    int pickCount = 0;
    public TMP_Text PickCount; // script를 바로 연결해도 됨

    public void Increase_PickCount(GameObject Clone)
    {
        pickCount++;
        PickCount.text = pickCount.ToString();

        Destroy(Clone); // 클릭된 object 없애기
    }
}