using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlantHolderManager : MonoBehaviour
{
    public GameObject[] PlantSpritesList;

    public int PlantType = -1; // Plant sprites are decided by type, status and stage

    public int TimeRemainToNextStage = 0;

    public int PlantStage = 0; // 0 = seed, 1 - 3 = stage, 4 = mature
    public int PlantStatus = 0; // 0 - growing, 1 - stop growing (event happens), 2 - mature, 3 - illness, 4 - die
    public bool healthStatus = true;

    public int PreferStage = 0;
    public int PreferStatus = 0;

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
        if (PlantType != -1 && PlantStatus != 4)
        {
            //if (PlantStatus == 0)
            //{
            if (TimeRemainToNextStage > 0) // time minus
            {
                //Debug.Log(TimeRemainToNextStage);
                TimeRemainToNextStage--;
                UpdateNextStage();
            }
            else if (TimeRemainToNextStage == 0) // next stage
            {
                if (PlantStage < 4)
                {
                    PlantStage = PreferStage;
                    PlantStatus = PreferStatus;
                    if (PreferStatus == 0) { healthStatus = true; } else { healthStatus = false; }
                    TimeRemainToNextStage = plantProperty.getStageTime();

                    stem_SpriteRenderer.sprite = plantProperty.getSprite(0, PlantStage, PlantStatus);
                    root_SpriteRenderer.sprite = plantProperty.getSprite(1, PlantStage, PlantStatus);
                }
                if (PlantStage == 4) {

                    TimeRemainToNextStage = -1;
                    PlantStatus = 0;
                    healthStatus = true;

                    PlantStatus = 2;
                }
                
            }

            //}
            //else if (PlantStatus == 1) {

            //}
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

    public void UpdateNextStage() {
        switch (healthStatus) {

            case true:
                if (PlantStage < 4)
                {
                    PreferStage = PlantStage + 1;
                    PreferStatus = 0;
                }
                else {
                    PreferStage = 4;
                    PreferStatus = 2;
                }
                break;
            case false:
                if (PlantStage > 1 && PlantStage < 4)
                {

                    PreferStage = PlantStage;
                    if (PlantStatus == 0)
                    {
                        PreferStatus = 3;
                    }
                    else
                    {
                        PreferStatus = 4;
                    }
                }
                else {
                    Debug.Log("This stage cannot be illness");
                }
                break;
        }


    }
}
