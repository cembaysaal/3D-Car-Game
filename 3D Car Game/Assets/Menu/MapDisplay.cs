
using UnityEngine;
using UnityEngine.UI;

public class MapDisplay : MonoBehaviour
{   
    [SerializeField] private Text mapName;
    [SerializeField] private Text mapDescription;
    [SerializeField] private Image mapImage;
    public void DisplayMap(Map _map)
    {
        mapName.text = _map.mapName;
        mapDescription.text = _map.mapDescription;
        mapImage.sprite = _map.mapImage;
    }
}
