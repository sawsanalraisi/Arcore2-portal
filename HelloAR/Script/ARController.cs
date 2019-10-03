using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

#if UNITY_EDITOR
  using input =GoogleARCore.InstantPreviewInput;
#endif


    public class ARController : MonoBehaviour
    {

        private List<TrackedPlane> m_NewTrackedPlanes = new List<TrackedPlane>();
        public GameObject GridPrefab;
        public GameObject Portal;
        public GameObject ArCamera;
        GameObject grid;
        public bool IsCreate = true;



        // Start is called before the first frame update
        void Start()
        {

        }



        public void VisualizePlanes(bool showPlanes)
        {
            foreach (GameObject plane in GameObject.FindGameObjectsWithTag("Plane"))
            {
                Renderer r = plane.GetComponent<Renderer>();
                GridVisualiser t = plane.GetComponent<GridVisualiser>();
                r.enabled = showPlanes;
                t.enabled = showPlanes;
            }
        }



        // Update is called once per frame
        void Update()
        {



            if (IsCreate == true)
            {
                if (Session.Status != SessionStatus.Tracking)
                {
                    return;
                }

                Session.GetTrackables<TrackedPlane>(m_NewTrackedPlanes, TrackableQueryFilter.New);

                for (int i = 0; i < m_NewTrackedPlanes.Count; i++)
                {
                    grid = Instantiate(GridPrefab, Vector3.zero, Quaternion.identity, transform);
                    grid.GetComponent<GridVisualiser>().Initialize(m_NewTrackedPlanes[i]);
                }

                Touch touch;
                if (Input.touchCount < 1 || (touch = Input.GetTouch(0)).phase != TouchPhase.Began)
                {
                    return;
                }

                TrackableHit hit;

                if (Frame.Raycast(touch.position.x, touch.position.y, TrackableHitFlags.PlaneWithinPolygon, out hit))
                {
                   // scale portal
                   //Portal.transform.localScale = new Vector3(1f, 1f, 1f);


                    Portal.SetActive(true);
                    Anchor anchor = hit.Trackable.CreateAnchor(hit.Pose);
                    Portal.transform.position = hit.Pose.position;
                    Portal.transform.rotation = hit.Pose.rotation;
                    Vector3 cameraPosition = ArCamera.transform.position;
                    cameraPosition.y = hit.Pose.position.y;
                    Portal.transform.LookAt(cameraPosition, Portal.transform.up);
                   // Portal.transform.parent = anchor.transform;
                   

                }

                IsCreate = false;

            }


            if (IsCreate == false)
            {
                foreach (GameObject plane in GameObject.FindGameObjectsWithTag("Plane"))
                {
                    Renderer r = plane.GetComponent<Renderer>();
                    GridVisualiser t = plane.GetComponent<GridVisualiser>();
                    r.enabled = false;
                    t.enabled = false;
                }
            }


        }

    }
