using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/GunData", fileName = "Gundata")]
public class GunData : ScriptableObject
{
    public AudioClip shotClip; 
    public AudioClip reloadClip;

    public float damage = 25;

    public int startAmmoRemain = 100;
    public int magCapacity = 25;
    
    public float timeBetFire = 0.12f;
    public float reloadTime = 1.8f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
