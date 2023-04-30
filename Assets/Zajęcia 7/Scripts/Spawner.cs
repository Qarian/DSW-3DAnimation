using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToCreate;

    public List<Track> tracks;

    public string objectName;
    private int counter = 1;

    private void Start()
    {
        CreateNew();
    }

    public void CreateNew()
    {
        GameObject clone = Instantiate(objectToCreate);
        clone.name = objectName + counter.ToString();
        clone.SetActive(true);
        counter++;

        PatrolAround patrolComponent = clone.GetComponent<PatrolAround>();
        SetTrack(patrolComponent);
        clone.GetComponent<TapKiller>().spawner = this;
    }

    private void SetTrack(PatrolAround patrolScript)
    {
        int randomIndex = Random.Range(0, tracks.Count);
        //Debug.Log("Chosen " + randomIndex.ToString() + " track");
        Debug.Log($"Chosen {randomIndex} track");
        Track chosenTrack = tracks[randomIndex];
        patrolScript.targets = chosenTrack.track;
    }
}
