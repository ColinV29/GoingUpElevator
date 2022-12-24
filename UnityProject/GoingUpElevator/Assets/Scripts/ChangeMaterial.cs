using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public GameObject Arrrow_Obj;
    public Material Go_NullMat;
    public Material GoGreen_Met;
    public Material GoRed_Met;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer renderer = Arrrow_Obj.GetComponent<MeshRenderer>();
        renderer.material = Go_NullMat;
    }

    //Uparrow green and red----------   
    public void Go_green()
    {
        MeshRenderer renderer = Arrrow_Obj.GetComponent<MeshRenderer>();
        renderer.material = GoGreen_Met;
    }

    public void Go_red()
    {
        MeshRenderer renderer = Arrrow_Obj.GetComponent<MeshRenderer>();
        renderer.material = GoRed_Met;
    }

    public void Go_Null()
    {
        MeshRenderer renderer = Arrrow_Obj.GetComponent<MeshRenderer>();
        renderer.material = Go_NullMat;
    }
}
