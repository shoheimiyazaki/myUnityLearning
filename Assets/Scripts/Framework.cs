using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyFramework
{
    public static float CalculateAirDensity(float altitude)
    {
        return 1.0f - altitude * 0.006f;
    }
    // Start is called before the first frame update

}
