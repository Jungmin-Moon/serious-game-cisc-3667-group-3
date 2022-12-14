using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskRender : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] PresistentData Mask;
    public GameObject maskUI; 
    
    void Start()
    {

        
  
    }
    public void ShowMask(){
        
        bool mask = Mask.GetMask(); 
        if(mask == true){
            maskUI.SetActive(true);
            Debug.Log("MaskUI"+ mask); 
        }
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
