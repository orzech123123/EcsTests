using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        entityManager.CreateEntity();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
