using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OOPExit : Identity
{
    public GameObject win;
    public override void Hit()
    {
        base.Hit();
        win.SetActive(true);
    }
}
