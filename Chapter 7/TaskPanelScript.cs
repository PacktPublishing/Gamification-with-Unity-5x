using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TaskPanelScript : MonoBehaviour {

    [HideInInspector]
    public Task task;

    public Image icon;
    public Text title;
    public Image priority;
    public Text status;
    public Text due;

    [HideInInspector]
    public TaskManager taskManager;

    public void UpdateGraphics() {
        title.text = task.title;
        icon.sprite = taskManager.taskIcons[task.icon];
        priority.sprite = taskManager.taskPriorities[task.priority];
        status.text = "Status: " + task.Status();
        due.text = "Due: " + task.expireDate.Date.ToString("dd/MM/yy");
    }

    public void taskCompleted() {
        task.isCompleted = true;
        UpdateGraphics();
    }

}