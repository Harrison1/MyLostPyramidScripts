using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SquareFireLVC : MonoBehaviour {
	
	public float fireTime;
	public float repeatTime;
	
	public GameObject blueSquare;
	public GameObject grnSquare;
	public GameObject purpSquare;
	public GameObject rdSquare;
	public GameObject tlSquare;
	public GameObject whtSquare;
	public GameObject ylwSquare;
	
	public int pooledAmount = 5;
	List<GameObject> squares;
	
	void Start() 
	{
		
		fireTime = Random.Range(1, 5);
		repeatTime = Random.Range(2, 6);
		
		squares = new List<GameObject> ();
		
		for(int i = 0; i < pooledAmount; i++)
		{
			GameObject blu = (GameObject)Instantiate(blueSquare);
			blu.SetActive(false);
			squares.Add(blu);
		}
		
		for(int i = 0; i < pooledAmount; i++)
		{
			GameObject grn = (GameObject)Instantiate(grnSquare);
			grn.SetActive(false);
			squares.Add(grn);
		} 
		
		for(int i = 0; i < pooledAmount; i++)
		{
			GameObject purp = (GameObject)Instantiate(purpSquare);
			purp.SetActive(false);
			squares.Add(purp);
		} 
		
		for(int i = 0; i < pooledAmount; i++)
		{
			GameObject rd = (GameObject)Instantiate(rdSquare);
			rd.SetActive(false);
			squares.Add(rd);
		} 
		
		for(int i = 0; i < pooledAmount; i++)
		{
			GameObject tl = (GameObject)Instantiate(tlSquare);
			tl.SetActive(false);
			squares.Add(tl);
		} 
		
		for(int i = 0; i < pooledAmount; i++)
		{
			GameObject wht = (GameObject)Instantiate(whtSquare);
			wht.SetActive(false);
			squares.Add(wht);
		} 
		
		for(int i = 0; i < pooledAmount; i++)
		{
			GameObject ylw = (GameObject)Instantiate(ylwSquare);
			ylw.SetActive(false);
			squares.Add(ylw);
		} 
		
		InvokeRepeating("Fire", fireTime, repeatTime);
	}
	
	void Fire()
	{
		for(int i = 0; i < squares.Count; i++)
		{
			i = Random.Range(0, squares.Count);
			if(!squares[i].activeInHierarchy)
			{
				squares[i].transform.position = transform.position;
				squares[i].transform.rotation = transform.rotation;
				squares[i].SetActive(true);
				break;
			}
		}
	}

	void FixedUpdate(){

	}
	
}
