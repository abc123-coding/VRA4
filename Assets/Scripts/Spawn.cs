using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public BoxCollider[] colliders; //랜덤 스폰할 콜라이더
    public GameObject[] prefabs;    //게임 오브젝트


    void Start()
    {
        SpawnObjects();
    }

    private void SpawnObjects()
    {
        for(int i = 0; i < prefabs.Length; i++)
        {
            int select_area = Random.Range(0, colliders.Length);

            Vector3 pos = GetRandomPosition(select_area);
            Instantiate(prefabs[i], pos, Quaternion.identity);

        }
    }

    private Vector3 GetRandomPosition(int s)
    {
        Vector3 base_pos = colliders[s].transform.position; //collider위치
        Debug.Log("collider : " + base_pos);
        Vector3 size = colliders[s].size;
        Debug.Log("size: " + size);

        float pos_x = base_pos.x + Random.Range(-size.x / 2f, size.x / 2f);
        float pos_y = base_pos.y + Random.Range(-size.y / 2f, size.y / 2f);
        float pos_z = base_pos.z + Random.Range(-size.z / 2f, size.z / 2f);

        Vector3 pos = new Vector3(pos_x, pos_y, pos_z);
        Debug.Log("random pos: " + pos);
        return pos;
    }
}
