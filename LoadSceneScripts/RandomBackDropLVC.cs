using UnityEngine;
using System.Collections;

public class RandomBackDropLVC : MonoBehaviour {

	public GameObject[] BackDrops;
	bool emptyBackDrop = true;

	void Awake () {
		if(emptyBackDrop == true){
			ChooseBackDrop();
		}

	}

	public void ChooseBackDrop () 
	{
		BackDrops[Random.Range(0, BackDrops.Length)].SetActive(true);
		emptyBackDrop = false;
	}
}
