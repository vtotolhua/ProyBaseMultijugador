
using UnityEngine;

public class WeaponShoot : Photon.MonoBehaviour
{

    public GameObject SpawnPoint;
    public GameObject Bala;

    public void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One)) {
            Dispara();
        }
    }


    public void Dispara()
    {
        GameObject temp = Instantiate(Bala, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        Destroy(temp, 3.0f);
    }

}