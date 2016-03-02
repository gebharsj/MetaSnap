using UnityEngine;
using System.Collections.Generic;

public class MetaSnap : MonoBehaviour
{
    public bool addedSocket;
    public Object socketPrefab;
    public GameObject socket;
    public List<GameObject> socketArray = new List<GameObject>();
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
        Debug.Log("added socket to the edge");
        socket = Instantiate(socketPrefab, gameObject.GetComponent<Collider>().bounds.max, transform.rotation) as GameObject;
        socketArray.Add(socket);
    }

    public void AddSocketSurface()
    {
        Debug.Log("Added socket to surface");
        socket = Instantiate(socketPrefab, gameObject.GetComponent<Collider>().bounds.min, transform.rotation) as GameObject;
        socketArray.Add(socket);
    }

    public void AddSocketManually()
    {
        Debug.Log("Added socket manually");
        //socketArray.Add(socket);
    }

    public void RemoveSocket(int index)
    {
        Debug.Log("Removed socket");
        socketArray.RemoveAt(index);
    }
}