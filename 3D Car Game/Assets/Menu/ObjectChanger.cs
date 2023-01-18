
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectChanger : MonoBehaviour
{
    [SerializeField]private ScriptableObject[] serializableObjects;
    [SerializeField]private MapDisplay mapDisplay;
    [SerializeField]private MapDisplay mapDisplay2;
    private int index;
    public int index2;

    private void Awake()
    {
        changeObject(0);
    }

    public void changeObject( int _ch)
    {
        index += _ch;
        if(index < 0) index = (serializableObjects.Length-1);
        else if (index > (serializableObjects.Length-1)) index = 0;

        if(mapDisplay != null) mapDisplay.DisplayMap((Map)serializableObjects[index]);
    }

    public void selected(bool check)
    {   
        if(check == true) {
            index2 = index;
            mapDisplay2.DisplayMap((Map)serializableObjects[index2]);
            }
        else {
            mapDisplay2.DisplayMap((Map)serializableObjects[0]);
        }
    }

    public void mapStart(){
        SceneManager.LoadScene(index2+1);
    }

}
