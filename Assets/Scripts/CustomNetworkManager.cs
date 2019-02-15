﻿using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class CustomNetworkManager : NetworkLobbyManager
{
    public float timer = 0f;
    public bool canRotate = true;

    public bool gameStarted = false;

    private void Update()
    {
        if (canRotate && Camera.main != null) Camera.main.transform.Rotate(Vector3.up * Time.deltaTime * 3f);
    }

    public override void OnStartServer()
    {
        CustomGameManager.ClearPlayers();
        base.OnStartServer();
    }

    public override void OnStopServer()
    {
        CustomGameManager.ClearPlayers();
        base.OnStopServer();
    }

    public override void OnLobbyServerPlayersReady()
    {
        base.OnLobbyServerPlayersReady();
        gameStarted = true;
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        base.OnClientDisconnect(conn);
    }
}