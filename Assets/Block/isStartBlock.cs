using UnityEngine;

namespace Assets.Block
{
    public class isStartBlock : MonoBehaviour
    {

        public float speed;

        // Use this for initialization
        void Start () {
	    
        }
       //allows the game to destroy gameobject.
        private void SelfDestruct()
        {
            Destroy(this.gameObject);
        }

        /*
         This method keep track of the game's speed. It allows the game 
         to change the speed in certain time keeping the game interesting.
         */
        public void SpeedUpdate()
        {
            if (Time.time >= 30)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed * 3);

                Invoke("SelfDestruct", 10f);

            }
            else if (Time.time >= 20)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed * 2);
                Invoke("SelfDestruct", 10f);
            }
            else
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
                Invoke("SelfDestruct", 10f);
            }
        }


        // Update is called once per frame
        void Update () {
            SpeedUpdate();
        }
    }
}
