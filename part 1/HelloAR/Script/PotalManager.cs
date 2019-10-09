using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PotalManager : MonoBehaviour
{

    public GameObject MainCamera;
    public GameObject []Sponza;
    private Material[] SponzaMaterials;
    // Start is called before the first frame update
    void Start()
    {
        
        SponzaMaterials = Sponza[0].GetComponent<Renderer>().sharedMaterials;
        SponzaMaterials = Sponza[1].GetComponent<Renderer>().sharedMaterials;
        SponzaMaterials = Sponza[2].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[3].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[4].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[5].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[6].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[7].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[8].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[9].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[10].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[11].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[12].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[13].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[14].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[15].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[16].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[17].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[18].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[19].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[20].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[21].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[22].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[23].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[24].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[25].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[26].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[27].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[28].GetComponent<Renderer>().sharedMaterials;
         SponzaMaterials = Sponza[29].GetComponent<Renderer>().sharedMaterials;
         
       

    }


    void OnTriggerStay(Collider collider)
    {

        Vector3 camPositionInPortalSpace = transform.InverseTransformPoint(MainCamera.transform.position);

        if(camPositionInPortalSpace.y<0.5f)
        {
            for(int i=0;i<SponzaMaterials.Length;i++)
            {
                SponzaMaterials[i].SetInt("_stencilComp",(int)CompareFunction.Always);
            }

        }
        else
        {
            for (int i = 0; i < SponzaMaterials.Length; i++)
            {
                SponzaMaterials[i].SetInt("_stencilComp", (int)CompareFunction.Equal);
            }


        }

    }














}
