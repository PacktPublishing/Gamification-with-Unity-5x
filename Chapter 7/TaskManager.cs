using UnityEngine;
using System.Collections;

public class TaskManager : MonoBehaviour {

    ArrayList tasks = new ArrayList();
    public GameObject taskDisplayer;
    public GameObject taskPanelPrefab;

    public Sprite[] taskIcons;
    public Sprite[] taskPriorities;

    public void deleteCompleted() {
        for (int i = tasks.Count - 1; i >= 0; i--) {
            if (((Task)tasks[i]).isCompleted)
                tasks.RemoveAt(i);
        }

        OnEnable();
    }

    void OnEnable() {
        //Destroy all the previous tasks
        for (int i = 0; i < taskDisplayer.transform.childCount; i++) {
            Destroy(taskDisplayer.transform.GetChild(i).gameObject);
        }
        if (tasks.Count > 0) {
            //Create a new task panel for each of them
            foreach (Task t in tasks) {
                GameObject temp = Instantiate(taskPanelPrefab);
                temp.transform.SetParent(taskDisplayer.transform);
                temp.GetComponent<TaskPanelScript>().task = t;
                temp.GetComponent<TaskPanelScript>().taskManager = this;
                temp.GetComponent<TaskPanelScript>().UpdateGraphics();
            }
        }
    }

    public void addTask(Task t) {
        tasks.Add(t);
    }
}
