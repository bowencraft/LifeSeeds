using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantHolderManager : MonoBehaviour
{
    public GameObject[] PlantSpritesList;

    public int PlantType = -1; // Plant sprites are decided by type, status and stage
    public int PlantStage = 0;
    public int PlantStatus = 0; // 0 - growing, 1 - stop growing (event happens), 2 - mature, 3 - illness, 4 - die
    public int TimeRemainToNextStage = 0;

    PlantObjectProperty plantProperty = null;
    SpriteRenderer stem_SpriteRenderer;
    SpriteRenderer root_SpriteRenderer;

    public GameObject rootHolder;

    // Start is called before the first frame update
    void Start()
    {
        stem_SpriteRenderer = this.GetComponent<SpriteRenderer>();
        root_SpriteRenderer = rootHolder.GetComponent<SpriteRenderer>();
        addNewPlant(0);

    }

    // Update is called once per frame
    void Update()
    {
        if (PlantType != -1)
        {
            if (PlantStatus == 0)
            {
                if (TimeRemainToNextStage > 0) // time minus
                {
                    Debug.Log(TimeRemainToNextStage);
                    TimeRemainToNextStage--;
                }
                else if (TimeRemainToNextStage == 0) // grow to next stage
                {
                    if (PlantStage < 4)
                    {
                        PlantStage++;
                        TimeRemainToNextStage = plantProperty.getStageTime();
                        stem_SpriteRenderer.sprite = plantProperty.getSprite(0, PlantStage, 0);
                        root_SpriteRenderer.sprite = plantProperty.getSprite(1, PlantStage, 0);
                    }
                    else
                    {
                        TimeRemainToNextStage = -1;
                        PlantStatus = 2;
                    }
                }
                else { } // mature or die

            }
            //GetComponent<SpriteRenderer>() = p_SpriteRenderer;

        }
    }

    public void addNewPlant(int type) {

        plantProperty = PlantSpritesList[type].GetComponent<PlantObjectProperty>();
        PlantType = type;
        TimeRemainToNextStage = plantProperty.getStageTime();
        PlantStage = 0;
        stem_SpriteRenderer.sprite = plantProperty.getSprite(0, PlantStage, 0);
        root_SpriteRenderer.sprite = plantProperty.getSprite(1, PlantStage, 0);
    }
}
