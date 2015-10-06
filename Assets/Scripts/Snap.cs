using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Snap : MonoBehaviour {

    public int currentObject = 0;
    public int currentEvent = 0;
    public List<LSObject> objects = new List<LSObject>();

    public enum EditorState { position, scale, rotation, color };
    public EditorState state = EditorState.position;

    public GameObject canvas;
    public GameObject snapVisual;
    public GameObject objectPrevew;
    public GameObject previewObjectPrefab;
    public List<GameObject> previewObjects = new List<GameObject>();
    public Vector3 mousePos;

    public bool showMain = true;
    public bool showSub = false;

    public int gridSizeX;
    public int gridSizeY;
    public int gridSizeZ;

    public float smallStep;
    public float largeStep;

    public float startX;
    public float startY;
    public float startZ;

    private float offsetY = 0;
    private float scrollRate = 0.1f;
    private float lastScroll = 0f;

    private Material lineMaterial;

    private Color mainColor = new Color(0f, 0f, 0f, 0.50f);
    private Color subColor = new Color(0f, 0f, 0f, 0.25f);

    public Color clickColor = new Color(0f, 0f, 0f, 0.25f);
    public Color dragColor = new Color(0f, 0f, 0f, 0.25f);

    [System.Serializable]
    public class click
    {
        public Vector2 pos;

        public click(Vector2 _pos) {
            pos = _pos;
        }
    }
    public List<click> clicks = new List<click>();

    [System.Serializable]
    public class drag
    {
        public Vector2 posStart;
        public Vector2 posEnd;
        public Vector2 scale;

        public drag(Vector2 _posStart, Vector2 _posEnd, Vector2 _scale)
        {
            posStart = _posStart;
            posEnd = _posEnd;
            scale = _scale;
        }
    }
    public List<drag> drags = new List<drag>();

    public bool clickBegin = false;
    public bool clickLeft = false;
    public Vector2 clickPos;
    public Vector2 clickMove;

    public void UpdateEventSelection(int selection)
    {
        currentEvent = selection;
    }

    void Update ()
    {
        int index = 0;
        LSObject o = objects[currentObject];
        objectPrevew.GetComponent<LineRenderer>().SetVertexCount(o.events.Count);
        foreach (LSObject.Event e in o.events)
        {
            objectPrevew.GetComponent<LineRenderer>().SetPosition(index, new Vector3(e.position.x, e.position.y, -1));
            if (!objectPrevew.transform.FindChild(index.ToString()))
            {
                previewObjects.Insert(index, Instantiate(previewObjectPrefab));
                previewObjects[index].transform.SetParent(objectPrevew.transform);
                previewObjects[index].name = index.ToString();

                int i = index;
                previewObjects[index].transform.FindChild("name").GetComponent<Text>().text = i.ToString();
                previewObjects[index].GetComponent<SelectEvent>().editor = this.gameObject;
                previewObjects[index].GetComponent<SelectEvent>().selection = i;
            }
            else
            {
                previewObjects[index].transform.position = e.position;
                if (e.scale.x > 0 && e.scale.y > 0)
                    previewObjects[index].GetComponent<RectTransform>().sizeDelta = e.scale;
                else
                    previewObjects[index].GetComponent<RectTransform>().sizeDelta = new Vector2(0.25f, 0.25f);
                previewObjects[index].GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, e.rotation);
            }
            index++;
        }

        gridSizeX = Mathf.RoundToInt(Camera.main.orthographicSize * 3.75f);
        gridSizeY = Mathf.RoundToInt(Camera.main.orthographicSize * 2.25f);
        startX = Mathf.RoundToInt(Camera.main.transform.position.x) - gridSizeX / 2f;
        startY = Mathf.RoundToInt(Camera.main.transform.position.y) - gridSizeY / 2f;

        float temp = 1 / smallStep;
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        mousePos = new Vector3((Mathf.RoundToInt(mousePos.x * temp))/temp, (Mathf.RoundToInt(mousePos.y * temp))/temp, mousePos.z);
        snapVisual.transform.position = mousePos;

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            clickLeft = Input.GetMouseButtonDown(0);
            clickBegin = true;
            clickPos = new Vector2(mousePos.x, mousePos.y);
        }

        if (clickBegin)
        {
            clickMove = clickPos - new Vector2(mousePos.x, mousePos.y);
            clickMove = new Vector3((Mathf.RoundToInt(clickMove.x * temp)) / temp, (Mathf.RoundToInt(clickMove.y * temp)) / temp);
        }

        if (clickBegin && Input.GetMouseButton(0) || clickBegin && Input.GetMouseButton(1))
        {
            if (clickMove != Vector2.zero)
            {
                if (clickLeft)
                {
                    state = EditorState.position;
                    objects[currentObject].events[currentEvent].position = clickPos - clickMove;
                }
                else
                {
                    state = EditorState.scale;
                    objects[currentObject].events[currentEvent].scale = new Vector2(Mathf.Abs(-clickMove.x), Mathf.Abs(-clickMove.y)) * 2;
                }
            }
        }

        if (clickBegin && Input.GetMouseButtonUp(0) || clickBegin && Input.GetMouseButtonUp(1))
        {
            if (clickMove == Vector2.zero)
            {
                if (clickLeft)
                {
                    state = EditorState.rotation;
                    objects[currentObject].events[currentEvent].rotation += 45;
                    if (objects[currentObject].events[currentEvent].rotation >= 360)
                        objects[currentObject].events[currentEvent].rotation = 0;
                    clicks.Add(new click(new Vector2(mousePos.x, mousePos.y)));
                }
                else
                {
                    state = EditorState.color;
                    objects[currentObject].events[currentEvent].color += 1;
                    clicks.Add(new click(new Vector2(mousePos.x, mousePos.y)));
                }
            }
            else
            {
                if (clickLeft)
                {
                    state = EditorState.position;
                    objects[currentObject].events[currentEvent].position = clickPos - clickMove;
                    drags.Add(new drag(clickPos, clickPos - clickMove, -clickMove));
                }
                else
                {
                    state = EditorState.scale;
                    objects[currentObject].events[currentEvent].scale = new Vector2(Mathf.Abs(-clickMove.x), Mathf.Abs(-clickMove.y)) * 2;
                    drags.Add(new drag(clickPos, clickPos - clickMove, -clickMove));
                }
            }
        }
	}

    void CreateLineMaterial()
    {
        if (!lineMaterial)
        {
            lineMaterial = new Material("Shader \"Lines/Colored Blended\" {" +
                "SubShader { Pass { " +
                "    Blend SrcAlpha OneMinusSrcAlpha " +
                "    ZWrite Off Cull Off Fog { Mode Off } " +
                "    BindChannels {" +
                "      Bind \"vertex\", vertex Bind \"color\", color }" +
                "} } }");
            lineMaterial.hideFlags = HideFlags.HideAndDontSave;
            lineMaterial.shader.hideFlags = HideFlags.HideAndDontSave;
        }
    }

    void OnPostRender()
    {
        RenderGrid();
        RenderClicks();
        RenderDrags();
    }

    void OnDrawGizmos()
    {
        RenderGrid();
        RenderClicks();
        RenderDrags();
    }

    void RenderClicks()
    {
        GL.Begin(GL.QUADS);

        foreach(click c in clicks) {
            GL.Color(clickColor);
            GL.Vertex3(c.pos.x - 0.25f, c.pos.y - 0.25f, 0);
            GL.Vertex3(c.pos.x + 0.25f, c.pos.y - 0.25f, 0);
            GL.Vertex3(c.pos.x + 0.25f, c.pos.y + 0.25f, 0);
            GL.Vertex3(c.pos.x - 0.25f, c.pos.y + 0.25f, 0);
        }

        GL.End();
    }

    void RenderDrags()
    {
        GL.Begin(GL.QUADS);

        foreach (drag d in drags)
        {
            GL.Color(dragColor);
            GL.Vertex3(d.posStart.x, d.posStart.y, 0);
            GL.Vertex3(d.posStart.x + d.scale.x, d.posStart.y, 0);
            GL.Vertex3(d.posStart.x + d.scale.x, d.posStart.y + d.scale.y, 0);
            GL.Vertex3(d.posStart.x, d.posStart.y + d.scale.y, 0);
        }

        GL.End();
    }

    void RenderGrid()
    {
        CreateLineMaterial();
        // set the current material
        lineMaterial.SetPass(0);

        GL.Begin(GL.LINES);

        if (showSub)
        {
            GL.Color(subColor);

            //Layers
            for (float j = 0; j <= gridSizeY; j += smallStep)
            {
                //X axis lines
                for (float i = 0; i <= gridSizeZ; i += smallStep)
                {
                    GL.Vertex3(startX, startY + j + offsetY, startZ + i);
                    GL.Vertex3(startX + gridSizeX, startY + j + offsetY, startZ + i);
                }

                //Z axis lines
                for (float i = 0; i <= gridSizeX; i += smallStep)
                {
                    GL.Vertex3(startX + i, j + offsetY, startZ);
                    GL.Vertex3(startX + i, j + offsetY, gridSizeZ);
                }
            }

            //Y axis lines
            for (float i = 0; i <= gridSizeZ; i += smallStep)
            {
                for (float k = 0; k <= gridSizeX; k += smallStep)
                {
                    GL.Vertex3(startX + k, startY + offsetY, startZ + i);
                    GL.Vertex3(startX + k, startY + gridSizeY, startZ + i);
                }
            }
        }

        if (showMain)
        {
            GL.Color(mainColor);

            //Layers
            for (float j = 0; j <= gridSizeY; j += largeStep)
            {
                //X axis lines
                for (float i = 0; i <= gridSizeZ; i += largeStep)
                {
                    GL.Vertex3(startX, startY + j + offsetY, startZ + i);
                    GL.Vertex3(startX + gridSizeX, startY + j + offsetY, startZ + i);
                }

                //Z axis lines
                for (float i = 0; i <= gridSizeX; i += largeStep)
                {
                    GL.Vertex3(startX + i, j + offsetY, startZ);
                    GL.Vertex3(startX + i, j + offsetY, gridSizeZ);
                }
            }

            //Y axis lines
            for (float i = 0; i <= gridSizeZ; i += largeStep)
            {
                for (float k = 0; k <= gridSizeX; k += largeStep)
                {
                    GL.Vertex3(startX + k, startY, startZ + i);
                    GL.Vertex3(startX + k, startY + gridSizeY, startZ + i);
                }
            }
        }


        GL.End();
    }
}
