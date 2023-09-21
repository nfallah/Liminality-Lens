using System;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour
{
    private static ChunkManager instance;

    public static Dictionary<Vector2Int, Chunk> Chunks { get; private set; }

    public const int chunkSize = 10, renderDistance = 10;

    private Vector2Int playerChunkPos;

    private void Awake()
    {
        if (instance != null)
        {
            throw new Exception("Unable to set instance -- value already established.");
        }

        instance = this;
    }

    private void Update()
    {
        Debug.Log(WorldToChunkPos(transform.position));
    }

    public static Vector2Int WorldToChunkPos(Vector3 worldPos)
    {
        return new Vector2Int(
            (int)(worldPos.x / chunkSize),
            (int)(worldPos.z / chunkSize));
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
    }
}
