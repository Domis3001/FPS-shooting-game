using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    // Start is called before the first frame update
    void Awake()
    {
        playerinput = new PlayerInput();
        onFoot = playerinput.OnFoot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
