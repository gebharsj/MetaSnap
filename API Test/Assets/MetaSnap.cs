using UnityEngine;
using System.Collections.Generic;

public class MetaSnap : MonoBehaviour
{
    public bool addedSocket;
    public Object socketPrefab;
    public GameObject socket;
    public string socketType;
    public List<GameObject> socketArray = new List<GameObject>();

    public MetaSnap(GameObject aSocket, string aSocketType)
    {
        socket = aSocket;
        socketType = aSocketType;
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddSocketEdge()
    {
        socket = Instantiate(socketPrefab, gameObject.GetComponent<Collider>().bounds.max, transform.rotation) as GameObject;
        socket.transform.SetParent(gameObject.transform);
        socketType = "Edge Socket ";
        socketArray.Add(socket);
        
    }

    public void AddSocketSurface()
    {
        socket = Instantiate(socketPrefab, gameObject.GetComponent<Collider>().bounds.min, transform.rotation) as GameObject;
        socket.transform.SetParent(gameObject.transform);
        socketType = "Surface Socket ";
        socketArray.Add(socket);        
    }

    public void AddSocketManually()
    {
        Debug.Log("Added socket manually");
        //socketArray.Add(socket);
    }

    public void RemoveSocket(int index)
    {
        DestroyImmediate(socketArray[index]);
        socketArray.RemoveAt(index);
    }
}