using Ganyariya.SampleAdder;
using UnityEngine;

public class UseAdder : MonoBehaviour
{
    [SerializeField] private int x;
    [SerializeField] private int y;
    
    void Start()
    {
        var adder = new Adder();
        var result = adder.Add(x, y);
        Debug.Log($"use adder package: x={x} + y={y} = {result}");
    }
}
