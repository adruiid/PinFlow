using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "Scriptable Objects/LevelData")]
public class LevelData : ScriptableObject
{
    public int levelId;
    public string levelName;
    public Sprite levelThumbnail;  // the image shown on your grid button
    public int threeStar = 10;
    public int twoStar   = 15;
    public int oneStar   = 20;
    public int startingJamSlots = 3;
    //public BlockConfig[] blocks;
    // NO fields for stars, locked, completed — those go in PlayerPrefs
}

