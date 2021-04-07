using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPuebloType", menuName = "ScriptableObjects/NewPuebloType", order = 1)]
public class PuebloTypes : ScriptableObject
{
    [Range(0,64)]
    public int maxWidth, maxDepth, maxHeight;
}
