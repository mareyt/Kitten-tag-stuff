using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class kick : MonoBehaviour
{
    [Header("THIS SCRIPT WAS MADE BY MARE. IT IS NOT YOURS.")]
    [Header("Distributing This Script Will Lead To A Permanent Ban")]

    public PhotonView ptView;

    void OnTriggerEnter(Collider other)
    {
        if (ptView.IsMine)
        {
            return;
        }
        else
        {
            Application.Quit();
        }
    }
}