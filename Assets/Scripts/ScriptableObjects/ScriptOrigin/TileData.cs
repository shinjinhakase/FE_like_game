using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TileData", menuName = "ScriptableObjects/TileData", order = 2)]
public class TileData : ScriptableObject {

    public Sprite sprite;
    public int cost;

}
