using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ProceduralAnimation/HandData", fileName ="HandData", order = 0), System.Serializable]
public class HandData : ScriptableObject
{
    public int FingerQuantity;

}