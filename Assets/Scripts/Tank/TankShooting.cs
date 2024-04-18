using UnityEngine;
using UnityEngine.UI;

public class TankShooting : MonoBehaviour
{
    public GameObject prefab;
    public Transform firePosition;
    public float minFirePower = 5f;
    public float maxFirePower = 30f;
    public float chargeRate = 10f;
    public float reload = 2f;

    private float currentFirePower;
    private bool isCharging;
    private float lastTimeFire;
    private bool canShot;

    void Update(){
        canShot = Time.time > lastTimeFire + reload;

        if (Input.GetButtonDown("Fire1")){
            currentFirePower = minFirePower;
            isCharging = true;
        }

        if (Input.GetButton("Fire1") && isCharging) {
            currentFirePower += chargeRate * Time.deltaTime;
            currentFirePower = Mathf.Min(currentFirePower, maxFirePower);
        }

        if (Input.GetButtonUp("Fire1") && canShot) {
            Fire();
            isCharging = false;
            lastTimeFire = Time.time;
        }
    }

    void Fire(){
        GameObject shot = Instantiate(prefab, firePosition.position, firePosition.rotation);
        Rigidbody rb = shot.GetComponent<Rigidbody>();
        rb.velocity = firePosition.forward * currentFirePower;
    }
}