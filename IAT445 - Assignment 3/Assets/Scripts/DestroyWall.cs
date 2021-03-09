using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "InnerWall Divider"){
            
                Destroy(col.gameObject);
            Debug.Log("test");
            
        }
       
    }
}
