using UnityEngine;

public class Gun : MonoBehaviour {


    public float damage = 10f;
    public float range = 100f;

    private AudioSource AudioSrc;


    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    void Start()
    {
        AudioSrc = GetComponent<AudioSource>(); 
    }



    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
        {
            AudioSrc.Play();
            Shoot();

        } 
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

           Enemy EnemyHitScan = hit.transform.GetComponent<Enemy>();
            if(EnemyHitScan != null)
            {
                EnemyHitScan.TakeDamage(damage);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 1f);
        }
    }
    
}
