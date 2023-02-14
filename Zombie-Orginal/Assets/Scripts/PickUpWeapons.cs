using UnityEngine;

public class PickUpWeapons : MonoBehaviour
{
    private RaycastHit hit;

    [SerializeField] private LayerMask weaponLayer;
    [SerializeField] private Transform weaponHolder;
    
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 2.5f, Color.green);

        if (Physics.Raycast(ray,out hit, 2.5f, weaponLayer) && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }
    }

    private void PickUp()
    {
        hit.collider.transform.position = weaponHolder.position;
        hit.collider.transform.rotation = weaponHolder.rotation;
        
        hit.collider.gameObject.GetComponent<Rigidbody>().useGravity = false;
        hit.collider.gameObject.GetComponent<BoxCollider>().enabled = false;

        hit.collider.transform.parent = transform;
        
        Debug.Log("Podniesione");
    }
}
