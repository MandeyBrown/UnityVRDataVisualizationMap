using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshBuilder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MeshFilter mf = GetComponent<MeshFilter>();
		Mesh mesh = mf.mesh;

		// Vertices
		Vector3[] vertices = new Vector3[] {
			//front face
			new Vector3(-1,1,1), //left top front, 0
			new Vector3(1,1,1), //right top front, 1
			new Vector3(-1,-1,1), // left bottom front, 2
			new Vector3(1,-1,1), //right bottom front, 3

			//back face
			new Vector3(1,1,-1), // right top back, 4
			new Vector3(-1,1,-1), //left top back, 5
			new Vector3(1,-1,-1),//right bottom back, 6
			new Vector3(-1,-1,-1),// left bottom back, 7

			//left face
			new Vector3(-1,1,-1), // left top back, 8
			new Vector3(-1,1,1), //left top front, 9
			new Vector3(-1,-1,-1),//left bottom back, 10
			new Vector3(-1,-1,1),// left bottom front, 11

			//right face
			new Vector3(1,1,1), // right top front, 12
			new Vector3(1,1,-1), // right top back, 13
			new Vector3(1,-1,1),//right bottom front, 14
			new Vector3(1,-1,-1),// right bottom back, 15

			//top face
			new Vector3(-1,1,-1), // left top back, 16
			new Vector3(1,1,-1), // right top back, 17
			new Vector3(-1,1,1),// left top front, 18
			new Vector3(1,1,1),// right top fron, 19

			//bottom face
			new Vector3(-1,-1,1), // left bottom front, 20
			new Vector3(1,-1,1), // right bottom front, 21
			new Vector3(-1,-1,-1),// left bottom back, 22
			new Vector3(1,-1,-1)// right bottom back, 23
		};

		// Triangles 3 points, clockwise determines which side is visible
		int[] triangles = new int[] {
			// front face
			0,2,3,//first triangle
			3,1,0,//second triangle

			// back face
			4,6,7,//first triangle
			7,5,4,//second triangle

		    // left face
			8,10,11,//first triangle
			11,9,8,//second triangle

			// right face
			12,14,15,//first triangle
			15,13,12,//second triangle

			// top face
			16,18,19,//first triangle
			19,17,16,//second triangle
						
			// bottom face
			20,22,23,//first triangle
			23,21,20//second triangle

		};
		
		// UVs
		Vector2[] uvs = new Vector2 [] {
			//front face// 0,0, is bottom left, 1,1 is top right

			// front face
			new Vector2(0,1),
			new Vector2(0,0),
			new Vector2(1,1),
			new Vector2(1,0),

			// back face
			new Vector2(0,1),
			new Vector2(0,0),
			new Vector2(1,1),
			new Vector2(1,0),

		    // left face
			new Vector2(0,1),
			new Vector2(0,0),
			new Vector2(1,1),
			new Vector2(1,0),

			// right face
			new Vector2(0,1),
			new Vector2(0,0),
			new Vector2(1,1),
			new Vector2(1,0),

			// top face
			new Vector2(0,1),
			new Vector2(0,0),
			new Vector2(1,1),
			new Vector2(1,0),
						
			// bottom face
			new Vector2(0,1),
			new Vector2(0,0),
			new Vector2(1,1),
			new Vector2(1,0)			

		};
		
		mesh.Clear ();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.uv = uvs;
		//mesh.Optimize();
		mesh.RecalculateNormals();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
