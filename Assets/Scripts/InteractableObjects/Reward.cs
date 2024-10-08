using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Reward : InteractableObject
{
    public List<GameObject> carrots;
    public bool interacted;
    private void Start() {
        SoundManager.Instance.PlaySound2D("rockSound");
    }
    public override void Interacted()
    {
        interacted = true;
        UIInventory.instance.AddItem(carrots[2]);
        UIInventory.instance.AddItem(carrots[1]);
        UIInventory.instance.AddItem(carrots[3]);
        UIInventory.instance.AddItem(carrots[0]);

        GetComponent<Collider2D>().enabled = false;
        enabled = false;
    }

    
    public void Animate(Transform endPos){
        transform.DOMoveY(endPos.position.y,1f);
    }
}
