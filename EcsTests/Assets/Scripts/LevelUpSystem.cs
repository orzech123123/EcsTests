﻿using Unity.Entities;
using UnityEngine;

public class LevelUpSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref LevelComponent component) =>
        {
            component.level += 1f * Time.DeltaTime;

            Debug.Log(component.level);
        }); 
    }
}
