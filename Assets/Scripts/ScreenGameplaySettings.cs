using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenGameplaySettings : MonoBehaviour
{
    [SerializeField] public float InitialSpeed = 1f;
    [SerializeField] public KeyCode ActionKey = KeyCode.Q;
    public float CurrentSpeed { get; private set; }

    private GlobalState _globalState;

    // Start is called before the first frame update
    void Start()
    {
        _globalState = FindObjectOfType<GlobalState>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentSpeed *= _globalState.GlobalSpeed;  
    }
}