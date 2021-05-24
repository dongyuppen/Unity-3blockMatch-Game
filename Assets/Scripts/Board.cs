using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // 이차원배열
    //private Tile[,] m_TilesArray = new Tile[6, 6];
    
    // 딕셔너리<Key, Value>
    private Dictionary<string, Tile> m_TilesDictionary = new Dictionary<string, Tile>();

    private GameObject m_TilePrefab;

    public int m_Width = 16;
    public int m_Height = 16;

    // Start is called before the first frame update
    void Start()
    {
        // 프리팹 ? -> 붕어빵 제작 툴
        m_TilePrefab = Resources.Load("Prefabs/CandyPurple") as GameObject;

        CreateTiles();
    }

    /// <summary>
    /// 프리팹을 이용하여 새로운 타일들을 생성한다.
    /// </summary>
    private void CreateTiles()
    {
        for (int y = 0; y < m_Height; y++)
        {
            for (int x = 0; x < m_Width; x++)
            {
                // key 값 예시: x,y 
                string key = x.ToString() + "," + y.ToString();

                Tile tile = Instantiate<Tile>(m_TilePrefab.transform.GetComponent<Tile>());

                tile.transform.SetParent(this.transform);
                tile.transform.position = new Vector3(x, y, 0f);

                m_TilesDictionary.Add(key, tile);
            }
        }
    }
}
