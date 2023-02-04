using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantObjectProperty : MonoBehaviour
{
    public Sprite stem_2_default;
    public Sprite stem_3_default;
    public Sprite stem_4_default; // mature

    public Sprite root_0_default; // seed
    public Sprite root_1_default;
    public Sprite root_2_default;
    public Sprite root_3_default;
    public Sprite root_4_default; //mature

    public Sprite stem_2_illness;
    public Sprite stem_3_illness;

    public Sprite root_2_illness;
    public Sprite root_3_illness;

    public Sprite stem_2_died;
    public Sprite stem_3_died;

    public Sprite root_2_died;
    public Sprite root_3_died;

    public int StageTime;
    public string PlantName;

    public int getStageTime() {
        return StageTime;
    }


    public Sprite getSprite(int part, int stage, int status) {
        if (part == 0) // stem
        {
            if (stage == 2)
            {
                if (status == 0) return stem_2_default;
                else if (status == 1) return stem_2_illness;
                else if (status == 2) return stem_2_died;
            }
            else if (stage == 3)
            {
                if (status == 0) return stem_3_default;
                else if (status == 1) return stem_3_illness;
                else if (status == 2) return stem_3_died;
            }
            else if (stage == 4)
            {
                if (status == 0) return stem_4_default;
            }
        }
        else if (part == 1) {
            if (stage == 0)
            {
                return root_0_default;
            }
            else if (stage == 1)
            {
                return root_1_default;
            }
            else if (stage == 2)
            {
                if (status == 0) return root_2_default;
                else if (status == 1) return root_2_illness;
                else if (status == 2) return root_2_died;
            }
            else if (stage == 3)
            {
                if (status == 0) return root_3_default;
                else if (status == 1) return root_3_illness;
                else if (status == 2) return root_3_died;
            }
            else if (stage == 4) {
                return root_4_default;
            }
            else
            {
                Debug.Log("Invalid parameters.");
            }

        }
        else
        {
            Debug.Log("Invalid parameters.");
        }
        return null;
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
