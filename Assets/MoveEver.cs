using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MoveEver : MonoBehaviour {
	public GameObject pref;
	// Use this for initialization
	void Start () {
	
	}

	void OnEnable(){
		StartCoroutine (move ());

	}
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator move() {
		int count = 0;
		float size = 0.5f;
		List<GameObject> lst = new List<GameObject> ();
		while (true) {
			yield return null;
			if (lst.Count > 4000) {
				foreach (GameObject ob in lst) {
					for (int i = 0; i < 1000; i++) {
						lst.
					}

						Destroy (ob);
				}
//				lst.Clear ();
				continue;

			}



			lst.Remove(

			float y = Random.Range (-size, size);
			float x = Random.Range (-size, size);
			GameObject te = Instantiate (pref, new Vector3 (x, y, 0), Quaternion.identity) as GameObject;
			te.AddComponent<Dt>();
			MeshRenderer red = te.GetComponent<MeshRenderer> ();
			red.material.color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
			
			lst.Add(te);
				

		}

	}
}

public class Dt : MonoBehaviour {
	void Update(){
		float size = 0.9f;
		float y = Random.Range (-size, size);
		float x = Random.Range (-size, size);
			transform.localPosition = new Vector3 (x, y, 0);

	}
}
