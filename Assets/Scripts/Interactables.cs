using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactables : MonoBehaviour
{
    //messege displayed to player when looking ant an interactable object.
    public string promptMessage;

    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //template fuction overriden by subclass
    }
}
