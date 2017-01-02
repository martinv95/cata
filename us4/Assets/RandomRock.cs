using UnityEngine;
using System.Collections;

public class RandomRock : MonoBehaviour {

    public GameObject gobj;
    public Vector3 Center;
    public Vector3 GeneratedRange;
    public Vector3 RockSize;
    public int MinRockNumber;
    public int MaxRockNumber;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < Random.Range(MinRockNumber, MaxRockNumber); i++)
        {
            Spawn();
        }        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Spawn() {
        Vector3 pos = Center + new Vector3(Random.Range(0, GeneratedRange.x), 0, Random.Range(0, GeneratedRange.z));
        gobj.transform.localScale = new Vector3(RockSize.x, RockSize.y, RockSize.x);
        Instantiate(gobj, pos, Quaternion.identity);
    }
}
