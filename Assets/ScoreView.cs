using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class ScoreView : MonoBehaviour
    {
        private Text displayTxt;

        // Start is called before the first frame update
        void Start()
        {
            displayTxt = GetComponentInChildren<Text>(true);
        }
        private void ScoreViewUpdate()
        {
            //allows to display the score into the screen. Value is passed from the ScoreMgr class
            if (displayTxt)
            {
                displayTxt.text = "Score = " + ScoreMgr.instance.score;
            }
        }
        // Update is called once per frame
        void Update()
        {
            ScoreViewUpdate();
        }
    }
}
