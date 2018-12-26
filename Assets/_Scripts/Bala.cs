using UnityEngine;

public class Bala : MonoBehaviour {
    
    public float FuerzaBala;
    // Update is called once per frame
    
    void Update () {
        transform.Translate(Vector3.forward * FuerzaBala * Time.deltaTime);
        //CuerpoBala.velocity = transform.forward * FuerzaBala * Time.deltaTime;
        //gameObject.GetComponent<Rigidbody>().velocity = gameObject.transform.forward * FuerzaBala * Time.deltaTime;
    }
}
