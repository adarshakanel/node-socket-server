using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Socket.Quobject.SocketIoClientDotNet.Client;

public class GameManager : MonoBehaviour
{
    private QSocket socket;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        socket = IO.Socket ("http://localhost:3000");

        socket.On(QSocket.EVENT_CONNECT, () => {
            Debug.Log("Connected");
            socket.Emit("test", "hello from unity");
        });

        socket.On ("test-2", data => {
            Debug.Log("data : " + data);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy () {
        socket.Disconnect();
    }

}
