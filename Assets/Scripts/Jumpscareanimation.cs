using UnityEngine;

public class PlayAnimationDirect : MonoBehaviour
{
    HitDetection Hitter;
    [SerializeField] private Animator animat;

    void Update()
    {
        Hitter = GameObject.Find("Player").GetComponent<HitDetection>();
        // Play animation with a key press (example: spacebar)
        if (Hitter.Jumpscareanim == true)
        {
            animat.SetBool("JumpON",true);
        }
    }
}

