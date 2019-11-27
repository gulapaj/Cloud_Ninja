using UnityEngine;

namespace Assets
{
    public class ScoreMgr : MonoBehaviour
    {
        public int score;
        public static ScoreMgr instance;
        public void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
