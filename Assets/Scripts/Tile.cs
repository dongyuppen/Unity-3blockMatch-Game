using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    // Property
    public int m_ID; // m_는  ID가 Tile클래스의 맴버변수라는 것을 알려주기위해 사용(편리함)


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Vector3 strength = new Vector3(0.1f, 0.1f, 0.1f);
        transform.DOPunchScale(strength, 1f);
    }
}
