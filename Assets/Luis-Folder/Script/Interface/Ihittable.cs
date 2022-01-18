using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ihittable : MonoBehaviour
{
    public interface IHittable
    {
        void Onhit(float damage = 0, GameObject Hitter = null);
    }
}
