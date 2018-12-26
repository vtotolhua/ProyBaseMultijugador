using UnityEngine;

public class Bala : MonoBehaviour {
    
    public float FuerzaBala;
    private Rigidbody CuerpoBala;
    // Update is called once per frame


    private void Start()
    {
        CuerpoBala = GetComponent<Rigidbody>();
    }


    void Update () {
        transform.Translate(Vector3.forward * FuerzaBala * Time.deltaTime);
        //CuerpoBala.velocity = transform.forward * FuerzaBala * Time.deltaTime;
    }
}
