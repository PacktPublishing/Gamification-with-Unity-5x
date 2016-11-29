using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectTaskIcon : MonoBehaviour {

    public TaskManager taskManager;
    public CreateTask createTask;
    private int counter;

    public void OnClick() {
        counter++;
        if (counter == taskManager.taskIcons.Length)
            counter = 0;
        GetComponent<Image>().sprite = taskManager.taskIcons[counter];
        createTask.setIcon(counter);
    }
}
