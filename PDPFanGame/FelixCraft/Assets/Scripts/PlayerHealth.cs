using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Starting Health Variable
    public int stHealth = 100;
    // Current Health
    public int currentHealth;
    // Reference the slide
    public Slider healthSlider;
    // Here we'll need to add a damage image, and the death audio.
    // public AudioClip deathClip;
    // public Image damageImage;
    // public float flashSpeed = 5f; <-- this is the flashing dmg img fade.
    // public Color flashColor = new Color(1f,0f,0f,0.5f); <- set to flash

    // Animator [name] references animator component
    // AudioSource [playerAudio] references audiosource component

    // Player Movement Ref
    PlayerMovement playerMovement;

    // We can add player shooting here: PlayerSHooting playerShooting;

    bool isDead;
    bool dmged;

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        currentHealth = stHealth;
    }

    /* void Update (){
     * if(dmged) dmgimg.color = flashcolor/ else dmgimg color = color.lerp(
     * dmgimg.color,color.clear,flashspeed*time.deltatime); Reset to dmged = false;
    }
    */

    public void TakeDamage(int amt)
    {
        dmged = true;
        currentHealth -= amt;
        healthSlider.value = currentHealth;

        if(currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }
    // Start is called before the first frame update
    void Death()
    {
        isDead = true;

        // Here we can add an annimation and the sfx
        // playerAudio.clip = deathClip;
        // playerAudio.Play();

        playerMovement.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
