using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class LSObject {

    [System.Serializable]
    public class Event
    {
        public bool _position = false;
        public bool _scale = false;
        public bool _rotation = false;
        public bool _color = false;
        public Vector2 position = Vector2.zero;
        public Vector2 scale = Vector2.zero;
        public int rotation = 0;
        public int color = 0;
    }
    public List<Event> events = new List<Event>();
}
