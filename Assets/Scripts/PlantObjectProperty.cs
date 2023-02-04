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

    public int getStageTime() {
        return StageTime;
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
