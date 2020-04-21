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
        
        var entity = entityManager.CreateEntity(typeof(LevelComponent));
        entityManager.SetComponentData(entity, new LevelComponent { level = 10 });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
