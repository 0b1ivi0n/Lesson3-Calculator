using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    // sum
    public float FirstNumberOfSum;
    public float SecondNumberOfSum;
    public float ResultSum;
    // dif
    public float FirstNumberOfDif;
    public float SecondNumberOfDif;
    public float ResultDif;
    //div
    public float FirstNumberOfDiv;
    public float SecondNumberOfDiv;
    public float ResultDiv;
    // mult
    public float FirstNumberOfMult;
    public float SecondNumberOfMult;
    public float ResultMult;





    void Start()
    {
        Sum(FirstNumberOfSum, SecondNumberOfSum);
        Dif(FirstNumberOfDif, SecondNumberOfDif);
        Div(FirstNumberOfDiv, SecondNumberOfDiv);
        Mult(FirstNumberOfMult, SecondNumberOfMult);
    }

    public void Sum(float firstNumber, float secondNumber)
    {
        ResultSum = firstNumber + secondNumber;
        Debug.Log("Sum: " + ResultSum);
    }


    public void Dif(float firstNumber, float secondNumber)
    {
        ResultDif = firstNumber - secondNumber;
        Debug.Log("Dif: " + ResultDif);
    }


    public void Div(float firstNumber, float secondNumber)
    {
        ResultDiv = firstNumber / secondNumber;
        Debug.Log("Div: " + ResultDiv);
    }


    public void Mult(float firstNumber, float secondNumber)
    {
        ResultMult = firstNumber * secondNumber;
        Debug.Log("Mult: " + ResultMult);
    }

}
