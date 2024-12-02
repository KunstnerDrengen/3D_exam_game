using UnityEngine;

public class PlayAnimationDirect : MonoBehaviour
{
    //Finds another script
    HitDetection Hitter;
    //Private animator to activate jumpscare
    [SerializeField] private Animator animat;

    void Update()
    {
        //Find player and checks if hes hit
        Hitter = GameObject.Find("Player").GetComponent<HitDetection>();

        // Plays the animation by activating the bool, when the "Hitter" bool is activated
        if (Hitter.Jumpscareanim == true)
        {
            animat.SetBool("JumpON",true);
        }
    }
}

