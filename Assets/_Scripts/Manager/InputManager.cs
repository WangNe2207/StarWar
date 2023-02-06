using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }

    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get=> mouseWorldPos; }

    [SerializeField] protected float isFiring = 0f;
    public float IsFiring { get => isFiring; }

    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("Only 1 Input Manager allow to exist");
        InputManager.instance = this;
    }
    private void Update()
    {
        this.GetMouseDown();
    }
    private void FixedUpdate()
    {
        this.GetMousePos();
    }
    void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    void GetMouseDown()
    {
        this.isFiring = Input.GetAxis("Fire1");
    }    
}
