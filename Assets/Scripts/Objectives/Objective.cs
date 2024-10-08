using UnityEngine;
using System;

public abstract class Objective : MonoBehaviour {
    public bool isDebug;
    public bool complete;
    [Header("Objective Type")]
    public ObjectiveType objectiveType;
    [Header("Objective Texts")]
    public string mainTextString;
    public string description;
    public event Action onComplete;

    public abstract void CheckComplete();
    protected virtual void Update() {
        CheckComplete();
       
    }

    public void OnComplete() {
        if(isDebug) Debug.Log("OnComplete method called");
        onComplete?.Invoke();
    }

    public void Complete() {
        if(isDebug)Debug.Log("Complete method called");
        UIManager.instance.ShowMessage("Objective Complete!");
        // Destroy(gameObject);
    }

    public virtual void OnEnable() {
        if(isDebug)Debug.Log("Objective OnEnable called");
        onComplete += Complete;
    }

    public virtual void OnDisable() {
        if(isDebug)Debug.Log("Objective OnDisable called");
        onComplete -= Complete;
    }


}