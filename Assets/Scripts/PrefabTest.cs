using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    GameObject tank;
    void Start()
    {
        tank = Managers.Resource.Instantiate("Tank");
        Managers.Resource.Destory(tank, 3.0f);
    }
}
