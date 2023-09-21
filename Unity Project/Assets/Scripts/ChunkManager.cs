using System;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    private static ChunkManager instance;

    private void Awake()
    {
        instance = this;
    }

    public static ChunkManager Instance
    {
        get
        {
            if (instance == null)
            {
                throw new Exception("Unable to get instance -- value not established.");
            }

            return instance;
        }

        set
        {
            if (instance != null)
            {
                throw new Exception("Unable to set instance -- value already established.");
            }

            instance = value;
        }
    }
}
