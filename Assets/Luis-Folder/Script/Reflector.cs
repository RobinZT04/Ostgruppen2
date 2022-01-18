

using UnityEngine;

public class Reflector //Used to store a reflector object's data (part of the reflection bug fix)
{
    public Collider2D collider;
    public string layerName;

    public Reflector(Collider2D _collider, string _layerName)
    {
        collider = _collider;
        layerName = _layerName;
    }
}
