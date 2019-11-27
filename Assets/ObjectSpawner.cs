using UnityEditor;
using UnityEngine;

namespace Assets
{
    public class ObjectSpawner : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject[] obj;
        public float time;
        public float repeat;
        

        // Start is called before the first frame update
        void Start()
        {
            //allows the called method to repeat in a given seconds and count.
            InvokeRepeating("ObjectSpawnLogicUpdate", time, repeat);
        }

        private void ObjectSpawnLogicUpdate()
        {

                Transform tf = GetComponent<Transform>();
                if (tf != null)
                {
                    Instantiate(obj[Random.Range(0,obj.Length)], tf.position, tf.rotation);
                }
         
        }

        // Update is called once per frame
        void Update()
        {
            
            
        }
    }
}
