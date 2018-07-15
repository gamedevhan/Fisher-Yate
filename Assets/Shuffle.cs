using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
	public List<Transform> Cubes = new List<Transform>();	
		
	public void OnButtonPress()
	{		
		ShuffleList(Cubes);
		Redraw();
	}

	private void ShuffleList<T>(IList<T> list)
	{
		for (int i = list.Count - 1; i > 0; i--)
		{
			int random = Random.Range(0, list.Count);
			T value = list[random];
			list[random] = list[i];
			list[i] = value;
		}
	}

	private void Redraw()
	{
		for (int i = 0; i < Cubes.Count; i++)
		{	
			Cubes[i].position = new Vector3( (i * 2) - 4, 0, 0);
		}
	}
}
