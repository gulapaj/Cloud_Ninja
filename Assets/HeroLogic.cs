using UnityEngine;

namespace Assets
{
    public class HeroLogic : MonoBehaviour
    {
        private Animator anim;
        private Vector2 axis;
        public GameObject mainGame;
        public GameObject panel;


        public void OnCollisionEnter(Collision collision)
        {
            /*this will check if the obstacles has a component name "Is Target" then it
            will proceed to the appropriate actions.             
             */
            if (collision.gameObject.GetComponent<isTarget>() != null)
            {
                SoundMgr.instance.GameOver();
                Destroy(collision.gameObject);
                mainGame.gameObject.SetActive(false);
                panel.gameObject.SetActive(true);
                Destroy(mainGame);
            }
            else if (collision.gameObject.GetComponent<IsRedCoin>() != null)
            {
                ScoreMgr.instance.score = ScoreMgr.instance.score + 5;
                SoundMgr.instance.TokenSound();
                Destroy(collision.gameObject);
            }
            else if (collision.gameObject.GetComponent<isBlueCoin>() != null)
            {
                ScoreMgr.instance.score = ScoreMgr.instance.score + 3;
                SoundMgr.instance.TokenSound();
                Destroy(collision.gameObject);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        /*
         Thi method is responsible for the Avatar's action. This
         allows the user to press certain keys in the keyboard which will
         then triggers the action assigned to it.
         */
        private void HeroLogicUpdate()
        {
            anim.speed = 1.4f;

            axis.x = Input.GetAxis("Horizontal");
            axis.y = Input.GetAxis("Vertical");
            if (anim != null)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    anim.SetTrigger("Jump");
                    SoundMgr.instance.JumpSound();
                }
                else if (Input.GetButtonDown("Fire1"))
                {
                    anim.SetTrigger("Slide");
                    SoundMgr.instance.SlideSound();
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    anim.SetTrigger("Hook");
                    SoundMgr.instance.SlideSound();
                }
                else
                {
                    anim.SetBool("Run", true);
                }

            }
        }

        // Update is called once per frame
        void Update()
        {
            HeroLogicUpdate();
        }
    }
}
